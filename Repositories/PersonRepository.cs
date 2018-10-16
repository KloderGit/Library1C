using Library1C.DTO;
using Library1C.Interfaces;
using ServiceReference1C;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public async Task<flGUIDs> GetGuidByPhoneOrEmail(string phone, string email)
        {
            var query = await service.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(phone, email);
            return query.@return as flGUIDs;
        }

        /// <summary>
        /// Создать ФЛ
        /// </summary>
        public async Task<flGUIDs> Add(string FIO, string Phone, string Email, DateTime BirthDay = default(DateTime), 
            string City = "", string Position = default(string), string Education = "", string Expirience="", string Address="" )
        {
            СоздатьФизЛицоResponse query = null;
            try
            {

                //query = await service.СоздатьФизЛицоAsync("Тестовое Физ Лицо6", "", "dfff@ds.ru", "", DateTime.MinValue, "", "", "", "89031453456");

                query = await service.СоздатьФизЛицоAsync(
                    FIO = String.IsNullOrEmpty(FIO) ? "" : FIO, 
                    City = String.IsNullOrEmpty(City) ? "" : City , 
                    Email = String.IsNullOrEmpty(Email) ? "" : Email, 
                    Position = String.IsNullOrEmpty(Position) ? "" : Position, 
                    BirthDay, 
                    Education = String.IsNullOrEmpty(Education) ? "" : Education, 
                    Expirience = String.IsNullOrEmpty(Expirience) ? "" : Expirience, 
                    Address = String.IsNullOrEmpty(Address) ? "" : Address, 
                    Phone = String.IsNullOrEmpty(Phone) ? "" : Phone
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return query?.@return as flGUIDs;
        }



        public async Task<string> Add2(AddPersonDTO value)
        {
            СоздатьФизЛицоResponse query = null;
            try
            {
                query = await service.СоздатьФизЛицоAsync(
                    value.FIO,
                    value.City,
                    value.Email,
                    value.Position,
                    value.BirthDay,
                    value.Education,
                    value.Expirience,
                    value.Address,
                    value.Phone
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return query?.@return.GUID;
        }




        public async Task<string> InviteTo1C(AddLeadDTO value)
        {
            ЗачислитьСтудентаResponse result = null;

            try
            {
                result = await service.ЗачислитьСтудентаAsync(
                        value.ProgramGuid,
                        value.UserGuid,
                        value.ContractTitle,
                        value.ContractGroup,
                        value.ContractSubGroup,
                        value.ContractEducationStart,
                        value.ContractEducationEnd,
                        value.ContractExpire,
                        value.DecreeTitle,
                        value.ContractPrice
                    );
            }
            catch (Exception ex)
            {

            }

            return result?.@return;
        }


        /// <summary>
        /// Получить Guid ФЛ по данным карты
        /// </summary>
        //public async Task<flGUIDs> GetGuidByCard(string login, string password)
        //{
        //    var query = await service.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(login, password);
        //    return query.@return;
        //}

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
