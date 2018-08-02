using Library1C.Interfaces;
using Library1C.Repositories;
using ServiceReference1C;
using System;

namespace Library1C
{
    public class UnitOfWork
    {
        ПФ_ПорталДПОPortTypeClient service;

        public UnitOfWork()
        {
            service = new ПФ_ПорталДПОPortTypeClient(ПФ_ПорталДПОPortTypeClient.EndpointConfiguration.ПФ_ПорталДПОSoap);
        }

        ICommonRepository<ProgramEdu> ProgramRepository;
        ICommonRepository<Дисциплина> LessonRepository;
        ICommonRepository<ФормаКонтроля> AttestationRepository;

        public ICommonRepository<ProgramEdu> Programs => ProgramRepository ?? (ProgramRepository = new ProgramRepository(service));
        public ICommonRepository<Дисциплина> Lessons => LessonRepository ?? (LessonRepository = new LessonRepository(service));
        public ICommonRepository<ФормаКонтроля> Attestations => AttestationRepository ?? (AttestationRepository = new AttestationRepository(service));

    }
}
