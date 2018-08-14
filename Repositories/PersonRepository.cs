using Library1C.Interfaces;
using ServiceReference1C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1C.Repositories
{
    public class PersonRepository : ICommonRepository<ДанныеПоФизЛицу>
    {
        ПФ_ПорталДПОPortTypeClient service;

        public PersonRepository(ПФ_ПорталДПОPortTypeClient source)
        {
            service = source;
        }

        public async Task<ДанныеПоФизЛицу> Get(string key)
        {
            return await GetFLAsync(key);
        }

        public async Task<ДанныеПоФизЛицу> Get(Guid key)
        {
            return await GetFLAsync(key.ToString());
        }

        /// <summary>
        /// Получить всех (очень много данных, лучше использоать с указанием периода)
        /// </summary>
        public async Task<IEnumerable<ДанныеПоФизЛицу>> GetList()
        {
            var query = await GetFromServiceAsync(new DateTime(2006, 1, 1), DateTime.Today);
            return query;
        }


        /// <summary>
        /// Получить всех измененных за период
        /// </summary>
        public async Task<IEnumerable<ДанныеПоФизЛицу>> GetList(DateTime startDate, DateTime endDate)
        {
            var query = await GetFromServiceAsync(startDate, endDate);
            return query;
        }


        /// <summary>
        /// Получить Guid ФЛ по телефону или почте
        /// </summary>
        public async Task<string> GetGuidByPhoneOrEmail(string phone, string email)
        {
            var query = await service.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(phone, email);
            return query.@return;
        }

        /// <summary>
        /// Получить Guid ФЛ по данным карты
        /// </summary>
        public async Task<string> GetGuidByCard(string login, string password)
        {
            var query = await service.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(login, password);
            return query.@return;
        }

        protected async Task<ДанныеПоФизЛицу> GetFLAsync(string guid)
        {
            var query = await service.ПолучитьДанныеОФЛAsync(guid);
            return query;
        }

        protected async Task<IEnumerable<ДанныеПоФизЛицу>> GetFromServiceAsync(DateTime startDate, DateTime endDate)
        {
            try
            {
                var query = await service.ПолучитьИзмененныеДанныеОФЛЗаПериодAsync(startDate.Date, endDate.Date);
                return query.@return as IEnumerable<ДанныеПоФизЛицу>;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
