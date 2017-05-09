using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using System.Diagnostics;
using System.Collections.ObjectModel;
using SampleMobileAzure.SampleMobileAzure;

namespace SampleMobileAzure
{
    public class BarangManager
    {
        private IMobileServiceTable<Barang> _barangTable;

        public BarangManager()
        {
            var client = new MobileServiceClient(Constants.ApplicationURL);
            _barangTable = client.GetTable<Barang>();
        }

        public async Task<ObservableCollection<Barang>> GetBarangAsync()
        {
            try
            {
                IEnumerable<Barang> barangs = await _barangTable.ToEnumerableAsync();
                return new ObservableCollection<Barang>(barangs);
            }
            catch (MobileServiceInvalidOperationException msioe)
            {
                Debug.WriteLine("@Invalid sync operation: {0}", msioe.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(@"Sync error: {0}", e.Message);
            }
            return null;
        }

        public async Task SaveTaskAsync(Barang barang)
        {
            if (barang.Id == null)
            {
                await _barangTable.InsertAsync(barang);
            }
            else
            {
                await _barangTable.UpdateAsync(barang);
            }
        }
    }
}
