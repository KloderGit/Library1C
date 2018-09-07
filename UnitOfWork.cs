using Library1C.Interfaces;
using Library1C.Repositories;
using ServiceReference1C;
using System;

namespace Library1C
{
    public class UnitOfWork
    {
        ПФ_ПорталДПОPortTypeClient service;

        public UnitOfWork(string user, string pass)
        {
            service = new ПФ_ПорталДПОPortTypeClient(ПФ_ПорталДПОPortTypeClient.EndpointConfiguration.ПФ_ПорталДПОSoap, user, pass);
        }

        ICommonRepository<ProgramEdu> ProgramRepository;
        ICommonRepository<Дисциплина> LessonRepository;
        ICommonRepository<ФормаКонтроля> AttestationRepository;
        PersonRepository PersonRepository;

        public ICommonRepository<ProgramEdu> Programs => ProgramRepository ?? (ProgramRepository = new ProgramRepository(service));
        public ICommonRepository<Дисциплина> Lessons => LessonRepository ?? (LessonRepository = new LessonRepository(service));
        public ICommonRepository<ФормаКонтроля> Attestations => AttestationRepository ?? (AttestationRepository = new AttestationRepository(service));

        public PersonRepository Persons => PersonRepository ?? (PersonRepository = new PersonRepository(service));

    }
}
