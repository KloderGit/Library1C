﻿//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace ServiceReference1C
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://localhost/dposervices", ConfigurationName = "ServiceReference1C.ПФ_ПорталДПОPortType")]
    public interface ПФ_ПорталДПОPortType
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьСлушателей", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСлушателейResponse> ПолучитьСлушателейAsync(ServiceReference1C.ПолучитьСлушателейRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьУспеваемость", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУспеваемостьResponse> ПолучитьУспеваемостьAsync(ServiceReference1C.ПолучитьУспеваемостьRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьДоговора", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДоговораResponse> ПолучитьДоговораAsync(ServiceReference1C.ПолучитьДоговораRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьОплаты", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОплатыResponse> ПолучитьОплатыAsync(ServiceReference1C.ПолучитьОплатыRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:СоздатьВедомость", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.СоздатьВедомостьResponse> СоздатьВедомостьAsync(ServiceReference1C.СоздатьВедомостьRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ВнестиОценки", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ВнестиОценкиResponse> ВнестиОценкиAsync(ServiceReference1C.ВнестиОценкиRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ОтправитьОценкиНаПортал", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ОтправитьОценкиНаПорталResponse> ОтправитьОценкиНаПорталAsync(ServiceReference1C.ОтправитьОценкиНаПорталRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ДобавитьСтудентаВВедомость", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВВедомостьResponse> ДобавитьСтудентаВВедомостьAsync(ServiceReference1C.ДобавитьСтудентаВВедомостьRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьПреподавателей", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПреподавателейResponse> ПолучитьПреподавателейAsync(ServiceReference1C.ПолучитьПреподавателейRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьФормыКонтроля", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьФормыКонтроляResponse> ПолучитьФормыКонтроляAsync(ServiceReference1C.ПолучитьФормыКонтроляRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьДисциплины", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДисциплиныResponse> ПолучитьДисциплиныAsync(ServiceReference1C.ПолучитьДисциплиныRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьПрограммыОбучения", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПрограммыОбученияResponse> ПолучитьПрограммыОбученияAsync(ServiceReference1C.ПолучитьПрограммыОбученияRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьГруппы", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьГруппыResponse> ПолучитьГруппыAsync(ServiceReference1C.ПолучитьГруппыRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьУровниОбразования", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУровниОбразованияResponse> ПолучитьУровниОбразованияAsync(ServiceReference1C.ПолучитьУровниОбразованияRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьБазовыеОбразования", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьБазовыеОбразованияResponse> ПолучитьБазовыеОбразованияAsync(ServiceReference1C.ПолучитьБазовыеОбразованияRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьОценки", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОценкиResponse> ПолучитьОценкиAsync(ServiceReference1C.ПолучитьОценкиRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьТипыДоговоров", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьТипыДоговоровResponse> ПолучитьТипыДоговоровAsync(ServiceReference1C.ПолучитьТипыДоговоровRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьПлательщиков", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПлательщиковResponse> ПолучитьПлательщиковAsync(ServiceReference1C.ПолучитьПлательщиковRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьОборудование", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОборудованиеResponse> ПолучитьОборудованиеAsync(ServiceReference1C.ПолучитьОборудованиеRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьГруппыПрограммОбучения", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьГруппыПрограммОбученияResponse> ПолучитьГруппыПрограммОбученияAsync(ServiceReference1C.ПолучитьГруппыПрограммОбученияRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьВидыПрограмм", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьВидыПрограммResponse> ПолучитьВидыПрограммAsync(ServiceReference1C.ПолучитьВидыПрограммRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьФормыОбучения", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьФормыОбученияResponse> ПолучитьФормыОбученияAsync(ServiceReference1C.ПолучитьФормыОбученияRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьСпециальности", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСпециальностиResponse> ПолучитьСпециальностиAsync(ServiceReference1C.ПолучитьСпециальностиRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьТипыМероприятий", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьТипыМероприятийResponse> ПолучитьТипыМероприятийAsync(ServiceReference1C.ПолучитьТипыМероприятийRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьКвалификации", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьКвалификацииResponse> ПолучитьКвалификацииAsync(ServiceReference1C.ПолучитьКвалификацииRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьВыдаваемыеДокументы", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьВыдаваемыеДокументыResponse> ПолучитьВыдаваемыеДокументыAsync(ServiceReference1C.ПолучитьВыдаваемыеДокументыRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьУспеваемостьСтудентов", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУспеваемостьСтудентовResponse> ПолучитьУспеваемостьСтудентовAsync(ServiceReference1C.ПолучитьУспеваемостьСтудентовRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьСлушателейПоФИО", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСлушателейПоФИОResponse> ПолучитьСлушателейПоФИОAsync(ServiceReference1C.ПолучитьСлушателейПоФИОRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:СоздатьАттестационнуюВедомость", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.СоздатьАттестационнуюВедомостьResponse> СоздатьАттестационнуюВедомостьAsync(ServiceReference1C.СоздатьАттестационнуюВедомостьRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ДобавитьСтудентаВАттестационнуюВедомост" +
            "ь", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВАттестационнуюВедомостьResponse> ДобавитьСтудентаВАттестационнуюВедомостьAsync(ServiceReference1C.ДобавитьСтудентаВАттестационнуюВедомостьRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:СоздатьВедомостьПосещаемости", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.СоздатьВедомостьПосещаемостиResponse> СоздатьВедомостьПосещаемостиAsync(ServiceReference1C.СоздатьВедомостьПосещаемостиRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ДобавитьСтудентаВВедомостьПосещаемости", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВВедомостьПосещаемостиResponse> ДобавитьСтудентаВВедомостьПосещаемостиAsync(ServiceReference1C.ДобавитьСтудентаВВедомостьПосещаемостиRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьДанныеОСлушателяхФЛ", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДанныеОСлушателяхФЛResponse> ПолучитьДанныеОСлушателяхФЛAsync(ServiceReference1C.ПолучитьДанныеОСлушателяхФЛRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьДанныеПоАттестациямФЛ", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ServiceReference1C.ФизЛицо> ПолучитьДанныеПоАттестациямФЛAsync(string GUIDФизЛица);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьДанныеОФЛ", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ServiceReference1C.ДанныеПоФизЛицу> ПолучитьДанныеОФЛAsync(string GUIDФизЛица);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьИзмененныеДанныеОФЛЗаПериод", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьИзмененныеДанныеОФЛЗаПериодResponse> ПолучитьИзмененныеДанныеОФЛЗаПериодAsync(ServiceReference1C.ПолучитьИзмененныеДанныеОФЛЗаПериодRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьИзмененныеДанныеОПрограммахДПОЗ" +
            "аПериод", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодResponse> ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодAsync(ServiceReference1C.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьДанныеОПрограмме", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ServiceReference1C.ProgramEdu> ПолучитьДанныеОПрограммеAsync(string GUIDПрограммы);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьGUIDФизЛицаПоКартеИПаролю", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<string> ПолучитьGUIDФизЛицаПоКартеИПаролюAsync(string login, string pass);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ПолучитьGUIDФизЛицаПоТелефонуИлиПочте", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеResponse> ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(ServiceReference1C.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:СоздатьФизЛицо", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.СоздатьФизЛицоResponse> СоздатьФизЛицоAsync(ServiceReference1C.СоздатьФизЛицоRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/dposervices#ПФ_ПорталДПО:ЗачислитьСтудента", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(НайденныйСлушатель[]))]
        System.Threading.Tasks.Task<ServiceReference1C.ЗачислитьСтудентаResponse> ЗачислитьСтудентаAsync(ServiceReference1C.ЗачислитьСтудентаRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class СтрокаСпискаСлушателей
    {

        private Слушатель слушательField;

        private БазовоеОбразование базовоеОбразованиеField;

        private УровеньОбразования уровеньОбразованияField;

        private Договор договорField;

        private Программа программаField;

        private ФормаОбучения формаОбученияField;

        private Группа группаField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Слушатель Слушатель
        {
            get
            {
                return this.слушательField;
            }
            set
            {
                this.слушательField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public БазовоеОбразование БазовоеОбразование
        {
            get
            {
                return this.базовоеОбразованиеField;
            }
            set
            {
                this.базовоеОбразованиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public УровеньОбразования УровеньОбразования
        {
            get
            {
                return this.уровеньОбразованияField;
            }
            set
            {
                this.уровеньОбразованияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public Договор Договор
        {
            get
            {
                return this.договорField;
            }
            set
            {
                this.договорField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public Программа Программа
        {
            get
            {
                return this.программаField;
            }
            set
            {
                this.программаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ФормаОбучения ФормаОбучения
        {
            get
            {
                return this.формаОбученияField;
            }
            set
            {
                this.формаОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public Группа Группа
        {
            get
            {
                return this.группаField;
            }
            set
            {
                this.группаField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Слушатель
    {

        private string гУИДField;

        private string гУИДФизЛицаField;

        private string наименованиеField;

        private string фамилияField;

        private string имяField;

        private string отчествоField;

        private System.DateTime датаРожденияField;

        private string полField;

        private string местоРожденияField;

        private string гражданствоField;

        private bool иностранныйГражданинField;

        private string сНИЛСField;

        private string иННField;

        private string страховаяКомпанияField;

        private string местоРаботыField;

        private string должностьField;

        private string скайпField;

        private string состояниеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ГУИДФизЛица
        {
            get
            {
                return this.гУИДФизЛицаField;
            }
            set
            {
                this.гУИДФизЛицаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Фамилия
        {
            get
            {
                return this.фамилияField;
            }
            set
            {
                this.фамилияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Имя
        {
            get
            {
                return this.имяField;
            }
            set
            {
                this.имяField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Отчество
        {
            get
            {
                return this.отчествоField;
            }
            set
            {
                this.отчествоField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 6)]
        public System.DateTime ДатаРождения
        {
            get
            {
                return this.датаРожденияField;
            }
            set
            {
                this.датаРожденияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Пол
        {
            get
            {
                return this.полField;
            }
            set
            {
                this.полField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string МестоРождения
        {
            get
            {
                return this.местоРожденияField;
            }
            set
            {
                this.местоРожденияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Гражданство
        {
            get
            {
                return this.гражданствоField;
            }
            set
            {
                this.гражданствоField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public bool ИностранныйГражданин
        {
            get
            {
                return this.иностранныйГражданинField;
            }
            set
            {
                this.иностранныйГражданинField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string СНИЛС
        {
            get
            {
                return this.сНИЛСField;
            }
            set
            {
                this.сНИЛСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string ИНН
        {
            get
            {
                return this.иННField;
            }
            set
            {
                this.иННField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string СтраховаяКомпания
        {
            get
            {
                return this.страховаяКомпанияField;
            }
            set
            {
                this.страховаяКомпанияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string МестоРаботы
        {
            get
            {
                return this.местоРаботыField;
            }
            set
            {
                this.местоРаботыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string Должность
        {
            get
            {
                return this.должностьField;
            }
            set
            {
                this.должностьField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string Скайп
        {
            get
            {
                return this.скайпField;
            }
            set
            {
                this.скайпField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string Состояние
        {
            get
            {
                return this.состояниеField;
            }
            set
            {
                this.состояниеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ФизЛицо
    {

        private ЭлементМассивСлушателейФЛ[] массивСлушателейФЛField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Слушатель", IsNullable = false)]
        public ЭлементМассивСлушателейФЛ[] МассивСлушателейФЛ
        {
            get
            {
                return this.массивСлушателейФЛField;
            }
            set
            {
                this.массивСлушателейФЛField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ЭлементМассивСлушателейФЛ
    {

        private string gUIDСлушателяField;

        private ПрограммаСлушателяФЛ programField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUIDСлушателя
        {
            get
            {
                return this.gUIDСлушателяField;
            }
            set
            {
                this.gUIDСлушателяField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ПрограммаСлушателяФЛ Program
        {
            get
            {
                return this.programField;
            }
            set
            {
                this.programField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ПрограммаСлушателяФЛ
    {

        private string gUIDПрограммыField;

        private ДисциплинаФЛ[] массивДисциплинФЛField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUIDПрограммы
        {
            get
            {
                return this.gUIDПрограммыField;
            }
            set
            {
                this.gUIDПрограммыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Дисциплина", IsNullable = false)]
        public ДисциплинаФЛ[] МассивДисциплинФЛ
        {
            get
            {
                return this.массивДисциплинФЛField;
            }
            set
            {
                this.массивДисциплинФЛField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ДисциплинаФЛ
    {

        private string gUIDДисциплиныField;

        private Аттестация аттестацияField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUIDДисциплины
        {
            get
            {
                return this.gUIDДисциплиныField;
            }
            set
            {
                this.gUIDДисциплиныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Аттестация Аттестация
        {
            get
            {
                return this.аттестацияField;
            }
            set
            {
                this.аттестацияField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Аттестация
    {

        private System.DateTime датаАттестацииField;

        private ВидАттестацииФЛ видАттестацииField;

        private ФормаАттестацииФЛ формаАттестацииField;

        private string результатField;

        private string gUIDВедомостиField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
        public System.DateTime ДатаАттестации
        {
            get
            {
                return this.датаАттестацииField;
            }
            set
            {
                this.датаАттестацииField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ВидАттестацииФЛ ВидАттестации
        {
            get
            {
                return this.видАттестацииField;
            }
            set
            {
                this.видАттестацииField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ФормаАттестацииФЛ ФормаАттестации
        {
            get
            {
                return this.формаАттестацииField;
            }
            set
            {
                this.формаАттестацииField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Результат
        {
            get
            {
                return this.результатField;
            }
            set
            {
                this.результатField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string GUIDВедомости
        {
            get
            {
                return this.gUIDВедомостиField;
            }
            set
            {
                this.gUIDВедомостиField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ВидАттестацииФЛ
    {

        private string gUIDField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ФормаАттестацииФЛ
    {

        private string gUIDField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ДанныеПоФизЛицу
    {

        private string xML_IDField;

        private string fNameField;

        private string sNameField;

        private string tNameField;

        private string sexField;

        private string websiteField;

        private string photoField;

        private string citizenshipField;

        private string birthField;

        private string phoneField;

        private string emailField;

        private string skypeField;

        private string cityField;

        private string adressField;

        private string postField;

        private string educationField;

        private ДанныеПоКарте[] cardListAllField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string XML_ID
        {
            get
            {
                return this.xML_IDField;
            }
            set
            {
                this.xML_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string fName
        {
            get
            {
                return this.fNameField;
            }
            set
            {
                this.fNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string sName
        {
            get
            {
                return this.sNameField;
            }
            set
            {
                this.sNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string tName
        {
            get
            {
                return this.tNameField;
            }
            set
            {
                this.tNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string website
        {
            get
            {
                return this.websiteField;
            }
            set
            {
                this.websiteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string photo
        {
            get
            {
                return this.photoField;
            }
            set
            {
                this.photoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string citizenship
        {
            get
            {
                return this.citizenshipField;
            }
            set
            {
                this.citizenshipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string birth
        {
            get
            {
                return this.birthField;
            }
            set
            {
                this.birthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string skype
        {
            get
            {
                return this.skypeField;
            }
            set
            {
                this.skypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string adress
        {
            get
            {
                return this.adressField;
            }
            set
            {
                this.adressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string post
        {
            get
            {
                return this.postField;
            }
            set
            {
                this.postField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string education
        {
            get
            {
                return this.educationField;
            }
            set
            {
                this.educationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 16)]
        [System.Xml.Serialization.XmlArrayItemAttribute("card", IsNullable = false)]
        public ДанныеПоКарте[] cardListAll
        {
            get
            {
                return this.cardListAllField;
            }
            set
            {
                this.cardListAllField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ДанныеПоКарте
    {

        private bool activeField;

        private string loginField;

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ДоговорСлушателяФЛ
    {

        private string gUIDField;

        private System.DateTime dataOpenField;

        private System.DateTime dataCloseField;

        private float priceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
        public System.DateTime DataOpen
        {
            get
            {
                return this.dataOpenField;
            }
            set
            {
                this.dataOpenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 2)]
        public System.DateTime DataClose
        {
            get
            {
                return this.dataCloseField;
            }
            set
            {
                this.dataCloseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public float Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ПрограммаОбученияФЛ
    {

        private string gUIDField;

        private string nameField;

        private string formEducationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string formEducation
        {
            get
            {
                return this.formEducationField;
            }
            set
            {
                this.formEducationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ДанныеОСлушателеФЛ
    {

        private string gUIDField;

        private string statusField;

        private ПрограммаОбученияФЛ programField;

        private ДоговорСлушателяФЛ contractField;

        private ГруппаФЛ groupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ПрограммаОбученияФЛ Program
        {
            get
            {
                return this.programField;
            }
            set
            {
                this.programField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ДоговорСлушателяФЛ Contract
        {
            get
            {
                return this.contractField;
            }
            set
            {
                this.contractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public ГруппаФЛ Group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ГруппаФЛ
    {

        private string gUIDField;

        private string nameField;

        private System.DateTime dataStartField;

        private System.DateTime dataFinishField;

        private string subGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 2)]
        public System.DateTime DataStart
        {
            get
            {
                return this.dataStartField;
            }
            set
            {
                this.dataStartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 3)]
        public System.DateTime DataFinish
        {
            get
            {
                return this.dataFinishField;
            }
            set
            {
                this.dataFinishField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string SubGroup
        {
            get
            {
                return this.subGroupField;
            }
            set
            {
                this.subGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class flGUIDs
    {

        private string gUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class category
    {

        private string gUIDField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class teacher
    {

        private string gUIDField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class subject
    {

        private string gUIDsubjectField;

        private string subjectNameField;

        private Attestation attestationField;

        private string durationField;

        private teacher teacherField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUIDsubject
        {
            get
            {
                return this.gUIDsubjectField;
            }
            set
            {
                this.gUIDsubjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string subjectName
        {
            get
            {
                return this.subjectNameField;
            }
            set
            {
                this.subjectNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public Attestation Attestation
        {
            get
            {
                return this.attestationField;
            }
            set
            {
                this.attestationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public teacher teacher
        {
            get
            {
                return this.teacherField;
            }
            set
            {
                this.teacherField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Attestation
    {

        private formControl formControlField;

        private ViewAttestation[] spisokVariantAttestationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public formControl formControl
        {
            get
            {
                return this.formControlField;
            }
            set
            {
                this.formControlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public ViewAttestation[] SpisokVariantAttestation
        {
            get
            {
                return this.spisokVariantAttestationField;
            }
            set
            {
                this.spisokVariantAttestationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class formControl
    {

        private string gUIDFormControlField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUIDFormControl
        {
            get
            {
                return this.gUIDFormControlField;
            }
            set
            {
                this.gUIDFormControlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ViewAttestation
    {

        private string gUIDViewAttestationField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUIDViewAttestation
        {
            get
            {
                return this.gUIDViewAttestationField;
            }
            set
            {
                this.gUIDViewAttestationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class formEdu
    {

        private string gUIDFormEducationField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string GUIDFormEducation
        {
            get
            {
                return this.gUIDFormEducationField;
            }
            set
            {
                this.gUIDFormEducationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ProgramEdu
    {

        private string xML_IDField;

        private string nameField;

        private string typeProgramField;

        private string viewProgramField;

        private formEdu formEducationField;

        private subject[] listOfSubjectsField;

        private string activeField;

        private System.DateTime acceptDateField;

        private category categoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string XML_ID
        {
            get
            {
                return this.xML_IDField;
            }
            set
            {
                this.xML_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string typeProgram
        {
            get
            {
                return this.typeProgramField;
            }
            set
            {
                this.typeProgramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string viewProgram
        {
            get
            {
                return this.viewProgramField;
            }
            set
            {
                this.viewProgramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public formEdu formEducation
        {
            get
            {
                return this.formEducationField;
            }
            set
            {
                this.formEducationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true, Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public subject[] listOfSubjects
        {
            get
            {
                return this.listOfSubjectsField;
            }
            set
            {
                this.listOfSubjectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 7)]
        public System.DateTime acceptDate
        {
            get
            {
                return this.acceptDateField;
            }
            set
            {
                this.acceptDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public category category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class НайденныйСлушатель
    {

        private object фИОField;

        private object программаОбученияField;

        private object состояниеField;

        private System.Nullable<System.DateTime> датаНачалаОбученияField;

        private System.Nullable<System.DateTime> датаОкончанияОбученияField;

        private object номерДипломаField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public object ФИО
        {
            get
            {
                return this.фИОField;
            }
            set
            {
                this.фИОField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public object ПрограммаОбучения
        {
            get
            {
                return this.программаОбученияField;
            }
            set
            {
                this.программаОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public object Состояние
        {
            get
            {
                return this.состояниеField;
            }
            set
            {
                this.состояниеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> ДатаНачалаОбучения
        {
            get
            {
                return this.датаНачалаОбученияField;
            }
            set
            {
                this.датаНачалаОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> ДатаОкончанияОбучения
        {
            get
            {
                return this.датаОкончанияОбученияField;
            }
            set
            {
                this.датаОкончанияОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public object НомерДиплома
        {
            get
            {
                return this.номерДипломаField;
            }
            set
            {
                this.номерДипломаField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ВыдаваемыйДокумент
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ПреподавательКратко
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Оборудование
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class УчебныйПлан
    {

        private Дисциплина дисциплинаField;

        private int часыField;

        private int сРСField;

        private ФормаКонтроля формаКонтроляField;

        private int всегоЧасовField;

        private Оборудование[] оборудованиеField;

        private Дисциплина[] зависимыеДисциплиныField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Дисциплина Дисциплина
        {
            get
            {
                return this.дисциплинаField;
            }
            set
            {
                this.дисциплинаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int Часы
        {
            get
            {
                return this.часыField;
            }
            set
            {
                this.часыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public int СРС
        {
            get
            {
                return this.сРСField;
            }
            set
            {
                this.сРСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ФормаКонтроля ФормаКонтроля
        {
            get
            {
                return this.формаКонтроляField;
            }
            set
            {
                this.формаКонтроляField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int ВсегоЧасов
        {
            get
            {
                return this.всегоЧасовField;
            }
            set
            {
                this.всегоЧасовField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Оборудование", Order = 5)]
        public Оборудование[] Оборудование
        {
            get
            {
                return this.оборудованиеField;
            }
            set
            {
                this.оборудованиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ЗависимыеДисциплины", Order = 6)]
        public Дисциплина[] ЗависимыеДисциплины
        {
            get
            {
                return this.зависимыеДисциплиныField;
            }
            set
            {
                this.зависимыеДисциплиныField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Дисциплина
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ФормаКонтроля
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ПрисваиваемаяКвалификация
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ТипМероприятия
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Специальность
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ВидПрограммы
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ГруппаПрограммыОбучения
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ПрограммаОбученияПолно
    {

        private string гУИДField;

        private string наименованиеField;

        private string полноеНаименованиеField;

        private System.DateTime датаУтвержденияField;

        private string статусField;

        private string описаниеПрограммыField;

        private bool федеральнаяПрограммаField;

        private int всегоЧасовField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ПолноеНаименование
        {
            get
            {
                return this.полноеНаименованиеField;
            }
            set
            {
                this.полноеНаименованиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 3)]
        public System.DateTime ДатаУтверждения
        {
            get
            {
                return this.датаУтвержденияField;
            }
            set
            {
                this.датаУтвержденияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Статус
        {
            get
            {
                return this.статусField;
            }
            set
            {
                this.статусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string ОписаниеПрограммы
        {
            get
            {
                return this.описаниеПрограммыField;
            }
            set
            {
                this.описаниеПрограммыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public bool ФедеральнаяПрограмма
        {
            get
            {
                return this.федеральнаяПрограммаField;
            }
            set
            {
                this.федеральнаяПрограммаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public int ВсегоЧасов
        {
            get
            {
                return this.всегоЧасовField;
            }
            set
            {
                this.всегоЧасовField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class СтрокаСпискаПрограммОбучения
    {

        private ПрограммаОбученияПолно программаОбученияField;

        private ГруппаПрограммыОбучения группаПрограммыОбученияField;

        private ВидПрограммы видПрограммыField;

        private ФормаОбучения формаОбученияField;

        private Специальность специальностьField;

        private ТипМероприятия типМероприятияField;

        private ПрисваиваемаяКвалификация присваиваемаяКвалификацияField;

        private УчебныйПлан[] учебныйПланField;

        private ПреподавательКратко[] преподавателиField;

        private ВыдаваемыйДокумент[] выдаваемыеДокументыField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ПрограммаОбученияПолно ПрограммаОбучения
        {
            get
            {
                return this.программаОбученияField;
            }
            set
            {
                this.программаОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ГруппаПрограммыОбучения ГруппаПрограммыОбучения
        {
            get
            {
                return this.группаПрограммыОбученияField;
            }
            set
            {
                this.группаПрограммыОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ВидПрограммы ВидПрограммы
        {
            get
            {
                return this.видПрограммыField;
            }
            set
            {
                this.видПрограммыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ФормаОбучения ФормаОбучения
        {
            get
            {
                return this.формаОбученияField;
            }
            set
            {
                this.формаОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public Специальность Специальность
        {
            get
            {
                return this.специальностьField;
            }
            set
            {
                this.специальностьField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ТипМероприятия ТипМероприятия
        {
            get
            {
                return this.типМероприятияField;
            }
            set
            {
                this.типМероприятияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ПрисваиваемаяКвалификация ПрисваиваемаяКвалификация
        {
            get
            {
                return this.присваиваемаяКвалификацияField;
            }
            set
            {
                this.присваиваемаяКвалификацияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("УчебныйПлан", Order = 7)]
        public УчебныйПлан[] УчебныйПлан
        {
            get
            {
                return this.учебныйПланField;
            }
            set
            {
                this.учебныйПланField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Преподаватель", IsNullable = false)]
        public ПреподавательКратко[] Преподаватели
        {
            get
            {
                return this.преподавателиField;
            }
            set
            {
                this.преподавателиField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public ВыдаваемыйДокумент[] ВыдаваемыеДокументы
        {
            get
            {
                return this.выдаваемыеДокументыField;
            }
            set
            {
                this.выдаваемыеДокументыField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ФормаОбучения
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Преподаватель
    {

        private string гУИДField;

        private string наименованиеField;

        private string полField;

        private System.DateTime датаРожденияField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Пол
        {
            get
            {
                return this.полField;
            }
            set
            {
                this.полField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 3)]
        public System.DateTime ДатаРождения
        {
            get
            {
                return this.датаРожденияField;
            }
            set
            {
                this.датаРожденияField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class СтрокаТЧВедомости
    {

        private string гУИДСлушателяField;

        private string гУИДОценкиField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИДСлушателя
        {
            get
            {
                return this.гУИДСлушателяField;
            }
            set
            {
                this.гУИДСлушателяField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ГУИДОценки
        {
            get
            {
                return this.гУИДОценкиField;
            }
            set
            {
                this.гУИДОценкиField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ДоговорКратко
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class СтрокаСпискаОплат
    {

        private System.DateTime датаОплатыField;

        private ДоговорКратко договорField;

        private float суммаField;

        private Плательщик плательщикField;

        private string номерПервичногоДокументаField;

        private System.DateTime датаПервичногоДокументаField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
        public System.DateTime ДатаОплаты
        {
            get
            {
                return this.датаОплатыField;
            }
            set
            {
                this.датаОплатыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ДоговорКратко Договор
        {
            get
            {
                return this.договорField;
            }
            set
            {
                this.договорField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public float Сумма
        {
            get
            {
                return this.суммаField;
            }
            set
            {
                this.суммаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public Плательщик Плательщик
        {
            get
            {
                return this.плательщикField;
            }
            set
            {
                this.плательщикField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string НомерПервичногоДокумента
        {
            get
            {
                return this.номерПервичногоДокументаField;
            }
            set
            {
                this.номерПервичногоДокументаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 5)]
        public System.DateTime ДатаПервичногоДокумента
        {
            get
            {
                return this.датаПервичногоДокументаField;
            }
            set
            {
                this.датаПервичногоДокументаField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Плательщик
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ЭлементМассиваДисциплин
    {

        private Дисциплина дисциплинаField;

        private int часыField;

        private ФормаКонтроля формаКонтроляField;

        private int сРСField;

        private int всегоЧасовField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Дисциплина Дисциплина
        {
            get
            {
                return this.дисциплинаField;
            }
            set
            {
                this.дисциплинаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int Часы
        {
            get
            {
                return this.часыField;
            }
            set
            {
                this.часыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ФормаКонтроля ФормаКонтроля
        {
            get
            {
                return this.формаКонтроляField;
            }
            set
            {
                this.формаКонтроляField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public int СРС
        {
            get
            {
                return this.сРСField;
            }
            set
            {
                this.сРСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int ВсегоЧасов
        {
            get
            {
                return this.всегоЧасовField;
            }
            set
            {
                this.всегоЧасовField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ЭлементМассиваСлушателей
    {

        private СлушательКратко слушательField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public СлушательКратко Слушатель
        {
            get
            {
                return this.слушательField;
            }
            set
            {
                this.слушательField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class СлушательКратко
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ТипДоговора
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ДоговорПолно
    {

        private string гУИДField;

        private System.DateTime датаЗаключенияField;

        private string номерField;

        private string финансированиеField;

        private float суммаField;

        private System.DateTime датаНачалаОбученияField;

        private System.DateTime датаОкончанияОбученияField;

        private System.DateTime датаЗакрытияField;

        private bool групповойField;

        private float скидкаField;

        private float суммаСоСкидкойField;

        private bool учитыватьСкидкуField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
        public System.DateTime ДатаЗаключения
        {
            get
            {
                return this.датаЗаключенияField;
            }
            set
            {
                this.датаЗаключенияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Номер
        {
            get
            {
                return this.номерField;
            }
            set
            {
                this.номерField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Финансирование
        {
            get
            {
                return this.финансированиеField;
            }
            set
            {
                this.финансированиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public float Сумма
        {
            get
            {
                return this.суммаField;
            }
            set
            {
                this.суммаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 5)]
        public System.DateTime ДатаНачалаОбучения
        {
            get
            {
                return this.датаНачалаОбученияField;
            }
            set
            {
                this.датаНачалаОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 6)]
        public System.DateTime ДатаОкончанияОбучения
        {
            get
            {
                return this.датаОкончанияОбученияField;
            }
            set
            {
                this.датаОкончанияОбученияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 7)]
        public System.DateTime ДатаЗакрытия
        {
            get
            {
                return this.датаЗакрытияField;
            }
            set
            {
                this.датаЗакрытияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public bool Групповой
        {
            get
            {
                return this.групповойField;
            }
            set
            {
                this.групповойField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public float Скидка
        {
            get
            {
                return this.скидкаField;
            }
            set
            {
                this.скидкаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public float СуммаСоСкидкой
        {
            get
            {
                return this.суммаСоСкидкойField;
            }
            set
            {
                this.суммаСоСкидкойField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public bool УчитыватьСкидку
        {
            get
            {
                return this.учитыватьСкидкуField;
            }
            set
            {
                this.учитыватьСкидкуField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class СтрокаСпискаДоговоров
    {

        private ДоговорПолно договорField;

        private Плательщик плательщикField;

        private ТипДоговора типДоговораField;

        private Программа программаField;

        private ЭлементМассиваСлушателей[] массивСлушателейField;

        private ЭлементМассиваДисциплин[] массивДисциплинField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ДоговорПолно Договор
        {
            get
            {
                return this.договорField;
            }
            set
            {
                this.договорField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Плательщик Плательщик
        {
            get
            {
                return this.плательщикField;
            }
            set
            {
                this.плательщикField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ТипДоговора ТипДоговора
        {
            get
            {
                return this.типДоговораField;
            }
            set
            {
                this.типДоговораField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public Программа Программа
        {
            get
            {
                return this.программаField;
            }
            set
            {
                this.программаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ЭлементМассиваСлушателей[] МассивСлушателей
        {
            get
            {
                return this.массивСлушателейField;
            }
            set
            {
                this.массивСлушателейField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ЭлементМассиваДисциплин[] МассивДисциплин
        {
            get
            {
                return this.массивДисциплинField;
            }
            set
            {
                this.массивДисциплинField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Программа
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class ОтличникУчебы
    {

        private bool значениеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public bool Значение
        {
            get
            {
                return this.значениеField;
            }
            set
            {
                this.значениеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Тема
    {

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Оценка
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class СтрокаСпискаУспеваемости
    {

        private СлушательКратко слушательField;

        private Программа программаField;

        private ФормаКонтроля формаКонтроляField;

        private Дисциплина дисциплинаField;

        private Оценка оценкаField;

        private Тема темаField;

        private ОтличникУчебы отличникУчебыField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public СлушательКратко Слушатель
        {
            get
            {
                return this.слушательField;
            }
            set
            {
                this.слушательField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Программа Программа
        {
            get
            {
                return this.программаField;
            }
            set
            {
                this.программаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ФормаКонтроля ФормаКонтроля
        {
            get
            {
                return this.формаКонтроляField;
            }
            set
            {
                this.формаКонтроляField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public Дисциплина Дисциплина
        {
            get
            {
                return this.дисциплинаField;
            }
            set
            {
                this.дисциплинаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public Оценка Оценка
        {
            get
            {
                return this.оценкаField;
            }
            set
            {
                this.оценкаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public Тема Тема
        {
            get
            {
                return this.темаField;
            }
            set
            {
                this.темаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ОтличникУчебы ОтличникУчебы
        {
            get
            {
                return this.отличникУчебыField;
            }
            set
            {
                this.отличникУчебыField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Подгруппа
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Группа
    {

        private string гУИДField;

        private string наименованиеField;

        private string гУИДПрограммыField;

        private System.DateTime датаНачалаField;

        private System.DateTime датаОкончанияField;

        private Подгруппа[] списокПодгруппField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ГУИДПрограммы
        {
            get
            {
                return this.гУИДПрограммыField;
            }
            set
            {
                this.гУИДПрограммыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 3)]
        public System.DateTime ДатаНачала
        {
            get
            {
                return this.датаНачалаField;
            }
            set
            {
                this.датаНачалаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 4)]
        public System.DateTime ДатаОкончания
        {
            get
            {
                return this.датаОкончанияField;
            }
            set
            {
                this.датаОкончанияField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public Подгруппа[] СписокПодгрупп
        {
            get
            {
                return this.списокПодгруппField;
            }
            set
            {
                this.списокПодгруппField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class Договор
    {

        private string гУИДField;

        private string наименованиеField;

        private string статусField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Статус
        {
            get
            {
                return this.статусField;
            }
            set
            {
                this.статусField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class УровеньОбразования
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://localhost/dposervices")]
    public partial class БазовоеОбразование
    {

        private string гУИДField;

        private string наименованиеField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ГУИД
        {
            get
            {
                return this.гУИДField;
            }
            set
            {
                this.гУИДField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Наименование
        {
            get
            {
                return this.наименованиеField;
            }
            set
            {
                this.наименованиеField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьСлушателей", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьСлушателейRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true)]
        public System.Nullable<System.DateTime> НаДату;

        public ПолучитьСлушателейRequest()
        {
        }

        public ПолучитьСлушателейRequest(System.Nullable<System.DateTime> НаДату)
        {
            this.НаДату = НаДату;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьСлушателейResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьСлушателейResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.СтрокаСпискаСлушателей[] @return;

        public ПолучитьСлушателейResponse()
        {
        }

        public ПолучитьСлушателейResponse(ServiceReference1C.СтрокаСпискаСлушателей[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьУспеваемость", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьУспеваемостьRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true)]
        public System.Nullable<System.DateTime> НаДату;

        public ПолучитьУспеваемостьRequest()
        {
        }

        public ПолучитьУспеваемостьRequest(System.Nullable<System.DateTime> НаДату)
        {
            this.НаДату = НаДату;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьУспеваемостьResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьУспеваемостьResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.СтрокаСпискаУспеваемости[] @return;

        public ПолучитьУспеваемостьResponse()
        {
        }

        public ПолучитьУспеваемостьResponse(ServiceReference1C.СтрокаСпискаУспеваемости[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьДоговора", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьДоговораRequest
    {

        public ПолучитьДоговораRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьДоговораResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьДоговораResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.СтрокаСпискаДоговоров[] @return;

        public ПолучитьДоговораResponse()
        {
        }

        public ПолучитьДоговораResponse(ServiceReference1C.СтрокаСпискаДоговоров[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьОплаты", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьОплатыRequest
    {

        public ПолучитьОплатыRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьОплатыResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьОплатыResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.СтрокаСпискаОплат[] @return;

        public ПолучитьОплатыResponse()
        {
        }

        public ПолучитьОплатыResponse(ServiceReference1C.СтрокаСпискаОплат[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "СоздатьВедомость", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class СоздатьВедомостьRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string ГУИДПреподавателя;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        public string ГУИДПрограммыОбучения;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 2)]
        public string ГУИДФормыКонтроля;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ГУИДДисциплины;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаСдачи;

        public СоздатьВедомостьRequest()
        {
        }

        public СоздатьВедомостьRequest(string ГУИДПреподавателя, string ГУИДПрограммыОбучения, string ГУИДФормыКонтроля, string ГУИДДисциплины, System.DateTime ДатаСдачи)
        {
            this.ГУИДПреподавателя = ГУИДПреподавателя;
            this.ГУИДПрограммыОбучения = ГУИДПрограммыОбучения;
            this.ГУИДФормыКонтроля = ГУИДФормыКонтроля;
            this.ГУИДДисциплины = ГУИДДисциплины;
            this.ДатаСдачи = ДатаСдачи;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "СоздатьВедомостьResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class СоздатьВедомостьResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string @return;

        public СоздатьВедомостьResponse()
        {
        }

        public СоздатьВедомостьResponse(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ВнестиОценки", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ВнестиОценкиRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.СтрокаТЧВедомости[] ОценкиВедомости;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        public string ГУИДВедомости;

        public ВнестиОценкиRequest()
        {
        }

        public ВнестиОценкиRequest(ServiceReference1C.СтрокаТЧВедомости[] ОценкиВедомости, string ГУИДВедомости)
        {
            this.ОценкиВедомости = ОценкиВедомости;
            this.ГУИДВедомости = ГУИДВедомости;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ВнестиОценкиResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ВнестиОценкиResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string @return;

        public ВнестиОценкиResponse()
        {
        }

        public ВнестиОценкиResponse(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ОтправитьОценкиНаПортал", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ОтправитьОценкиНаПорталRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string ГУИДВедомости;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ГУИДСлушателя;

        public ОтправитьОценкиНаПорталRequest()
        {
        }

        public ОтправитьОценкиНаПорталRequest(string ГУИДВедомости, string ГУИДСлушателя)
        {
            this.ГУИДВедомости = ГУИДВедомости;
            this.ГУИДСлушателя = ГУИДСлушателя;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ОтправитьОценкиНаПорталResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ОтправитьОценкиНаПорталResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.СтрокаТЧВедомости[] @return;

        public ОтправитьОценкиНаПорталResponse()
        {
        }

        public ОтправитьОценкиНаПорталResponse(ServiceReference1C.СтрокаТЧВедомости[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ДобавитьСтудентаВВедомость", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ДобавитьСтудентаВВедомостьRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string ГУИДСлушателя;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        public string ГУИДВедомости;

        public ДобавитьСтудентаВВедомостьRequest()
        {
        }

        public ДобавитьСтудентаВВедомостьRequest(string ГУИДСлушателя, string ГУИДВедомости)
        {
            this.ГУИДСлушателя = ГУИДСлушателя;
            this.ГУИДВедомости = ГУИДВедомости;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ДобавитьСтудентаВВедомостьResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ДобавитьСтудентаВВедомостьResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string @return;

        public ДобавитьСтудентаВВедомостьResponse()
        {
        }

        public ДобавитьСтудентаВВедомостьResponse(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьПреподавателей", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьПреподавателейRequest
    {

        public ПолучитьПреподавателейRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьПреподавателейResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьПреподавателейResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.Преподаватель[] @return;

        public ПолучитьПреподавателейResponse()
        {
        }

        public ПолучитьПреподавателейResponse(ServiceReference1C.Преподаватель[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьФормыКонтроля", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьФормыКонтроляRequest
    {

        public ПолучитьФормыКонтроляRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьФормыКонтроляResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьФормыКонтроляResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ФормаКонтроля[] @return;

        public ПолучитьФормыКонтроляResponse()
        {
        }

        public ПолучитьФормыКонтроляResponse(ServiceReference1C.ФормаКонтроля[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьДисциплины", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьДисциплиныRequest
    {

        public ПолучитьДисциплиныRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьДисциплиныResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьДисциплиныResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.Дисциплина[] @return;

        public ПолучитьДисциплиныResponse()
        {
        }

        public ПолучитьДисциплиныResponse(ServiceReference1C.Дисциплина[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьПрограммыОбучения", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьПрограммыОбученияRequest
    {

        public ПолучитьПрограммыОбученияRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьПрограммыОбученияResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьПрограммыОбученияResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.СтрокаСпискаПрограммОбучения[] @return;

        public ПолучитьПрограммыОбученияResponse()
        {
        }

        public ПолучитьПрограммыОбученияResponse(ServiceReference1C.СтрокаСпискаПрограммОбучения[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьГруппы", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьГруппыRequest
    {

        public ПолучитьГруппыRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьГруппыResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьГруппыResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.Группа[] @return;

        public ПолучитьГруппыResponse()
        {
        }

        public ПолучитьГруппыResponse(ServiceReference1C.Группа[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьУровниОбразования", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьУровниОбразованияRequest
    {

        public ПолучитьУровниОбразованияRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьУровниОбразованияResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьУровниОбразованияResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.УровеньОбразования[] @return;

        public ПолучитьУровниОбразованияResponse()
        {
        }

        public ПолучитьУровниОбразованияResponse(ServiceReference1C.УровеньОбразования[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьБазовыеОбразования", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьБазовыеОбразованияRequest
    {

        public ПолучитьБазовыеОбразованияRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьБазовыеОбразованияResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьБазовыеОбразованияResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.БазовоеОбразование[] @return;

        public ПолучитьБазовыеОбразованияResponse()
        {
        }

        public ПолучитьБазовыеОбразованияResponse(ServiceReference1C.БазовоеОбразование[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьОценки", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьОценкиRequest
    {

        public ПолучитьОценкиRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьОценкиResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьОценкиResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.Оценка[] @return;

        public ПолучитьОценкиResponse()
        {
        }

        public ПолучитьОценкиResponse(ServiceReference1C.Оценка[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьТипыДоговоров", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьТипыДоговоровRequest
    {

        public ПолучитьТипыДоговоровRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьТипыДоговоровResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьТипыДоговоровResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ТипДоговора[] @return;

        public ПолучитьТипыДоговоровResponse()
        {
        }

        public ПолучитьТипыДоговоровResponse(ServiceReference1C.ТипДоговора[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьПлательщиков", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьПлательщиковRequest
    {

        public ПолучитьПлательщиковRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьПлательщиковResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьПлательщиковResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.Плательщик[] @return;

        public ПолучитьПлательщиковResponse()
        {
        }

        public ПолучитьПлательщиковResponse(ServiceReference1C.Плательщик[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьОборудование", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьОборудованиеRequest
    {

        public ПолучитьОборудованиеRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьОборудованиеResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьОборудованиеResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.Оборудование[] @return;

        public ПолучитьОборудованиеResponse()
        {
        }

        public ПолучитьОборудованиеResponse(ServiceReference1C.Оборудование[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьГруппыПрограммОбучения", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьГруппыПрограммОбученияRequest
    {

        public ПолучитьГруппыПрограммОбученияRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьГруппыПрограммОбученияResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьГруппыПрограммОбученияResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ГруппаПрограммыОбучения[] @return;

        public ПолучитьГруппыПрограммОбученияResponse()
        {
        }

        public ПолучитьГруппыПрограммОбученияResponse(ServiceReference1C.ГруппаПрограммыОбучения[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьВидыПрограмм", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьВидыПрограммRequest
    {

        public ПолучитьВидыПрограммRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьВидыПрограммResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьВидыПрограммResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ВидПрограммы[] @return;

        public ПолучитьВидыПрограммResponse()
        {
        }

        public ПолучитьВидыПрограммResponse(ServiceReference1C.ВидПрограммы[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьФормыОбучения", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьФормыОбученияRequest
    {

        public ПолучитьФормыОбученияRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьФормыОбученияResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьФормыОбученияResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ФормаОбучения[] @return;

        public ПолучитьФормыОбученияResponse()
        {
        }

        public ПолучитьФормыОбученияResponse(ServiceReference1C.ФормаОбучения[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьСпециальности", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьСпециальностиRequest
    {

        public ПолучитьСпециальностиRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьСпециальностиResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьСпециальностиResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.Специальность[] @return;

        public ПолучитьСпециальностиResponse()
        {
        }

        public ПолучитьСпециальностиResponse(ServiceReference1C.Специальность[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьТипыМероприятий", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьТипыМероприятийRequest
    {

        public ПолучитьТипыМероприятийRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьТипыМероприятийResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьТипыМероприятийResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ТипМероприятия[] @return;

        public ПолучитьТипыМероприятийResponse()
        {
        }

        public ПолучитьТипыМероприятийResponse(ServiceReference1C.ТипМероприятия[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьКвалификации", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьКвалификацииRequest
    {

        public ПолучитьКвалификацииRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьКвалификацииResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьКвалификацииResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ПрисваиваемаяКвалификация[] @return;

        public ПолучитьКвалификацииResponse()
        {
        }

        public ПолучитьКвалификацииResponse(ServiceReference1C.ПрисваиваемаяКвалификация[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьВыдаваемыеДокументы", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьВыдаваемыеДокументыRequest
    {

        public ПолучитьВыдаваемыеДокументыRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьВыдаваемыеДокументыResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьВыдаваемыеДокументыResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ВыдаваемыйДокумент[] @return;

        public ПолучитьВыдаваемыеДокументыResponse()
        {
        }

        public ПолучитьВыдаваемыеДокументыResponse(ServiceReference1C.ВыдаваемыйДокумент[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьУспеваемостьСтудентов", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьУспеваемостьСтудентовRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ГУИДСлушателя;

        public ПолучитьУспеваемостьСтудентовRequest()
        {
        }

        public ПолучитьУспеваемостьСтудентовRequest(string ГУИДСлушателя)
        {
            this.ГУИДСлушателя = ГУИДСлушателя;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьУспеваемостьСтудентовResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьУспеваемостьСтудентовResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.СтрокаСпискаУспеваемости[] @return;

        public ПолучитьУспеваемостьСтудентовResponse()
        {
        }

        public ПолучитьУспеваемостьСтудентовResponse(ServiceReference1C.СтрокаСпискаУспеваемости[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьСлушателейПоФИО", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьСлушателейПоФИОRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ФИО;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string НомерДиплома;

        public ПолучитьСлушателейПоФИОRequest()
        {
        }

        public ПолучитьСлушателейПоФИОRequest(string ФИО, string НомерДиплома)
        {
            this.ФИО = ФИО;
            this.НомерДиплома = НомерДиплома;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьСлушателейПоФИОResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьСлушателейПоФИОResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ServiceReference1C.НайденныйСлушатель[] @return;

        public ПолучитьСлушателейПоФИОResponse()
        {
        }

        public ПолучитьСлушателейПоФИОResponse(ServiceReference1C.НайденныйСлушатель[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "СоздатьАттестационнуюВедомость", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class СоздатьАттестационнуюВедомостьRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string GUIDTeacher;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        public string GUIDProgram;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 2)]
        public string GUIDFormControl;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string GUIDSubject;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string GUIDGroup;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Data;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Number;

        public СоздатьАттестационнуюВедомостьRequest()
        {
        }

        public СоздатьАттестационнуюВедомостьRequest(string GUIDTeacher, string GUIDProgram, string GUIDFormControl, string GUIDSubject, string GUIDGroup, System.DateTime Data, string Number)
        {
            this.GUIDTeacher = GUIDTeacher;
            this.GUIDProgram = GUIDProgram;
            this.GUIDFormControl = GUIDFormControl;
            this.GUIDSubject = GUIDSubject;
            this.GUIDGroup = GUIDGroup;
            this.Data = Data;
            this.Number = Number;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "СоздатьАттестационнуюВедомостьResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class СоздатьАттестационнуюВедомостьResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string @return;

        public СоздатьАттестационнуюВедомостьResponse()
        {
        }

        public СоздатьАттестационнуюВедомостьResponse(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ДобавитьСтудентаВАттестационнуюВедомость", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ДобавитьСтудентаВАттестационнуюВедомостьRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string GUIDAV;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        public string GUIDStudent;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 2)]
        public string GUIDRate;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> excellent;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string comment;

        public ДобавитьСтудентаВАттестационнуюВедомостьRequest()
        {
        }

        public ДобавитьСтудентаВАттестационнуюВедомостьRequest(string GUIDAV, string GUIDStudent, string GUIDRate, System.Nullable<bool> excellent, string comment)
        {
            this.GUIDAV = GUIDAV;
            this.GUIDStudent = GUIDStudent;
            this.GUIDRate = GUIDRate;
            this.excellent = excellent;
            this.comment = comment;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ДобавитьСтудентаВАттестационнуюВедомостьResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ДобавитьСтудентаВАттестационнуюВедомостьResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string @return;

        public ДобавитьСтудентаВАттестационнуюВедомостьResponse()
        {
        }

        public ДобавитьСтудентаВАттестационнуюВедомостьResponse(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "СоздатьВедомостьПосещаемости", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class СоздатьВедомостьПосещаемостиRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string GUIDProgram;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string GUIDSubject;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string GUIDGroup;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string GUIDSubGroup;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Data;

        public СоздатьВедомостьПосещаемостиRequest()
        {
        }

        public СоздатьВедомостьПосещаемостиRequest(string GUIDProgram, string GUIDSubject, string GUIDGroup, string GUIDSubGroup, System.DateTime Data)
        {
            this.GUIDProgram = GUIDProgram;
            this.GUIDSubject = GUIDSubject;
            this.GUIDGroup = GUIDGroup;
            this.GUIDSubGroup = GUIDSubGroup;
            this.Data = Data;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "СоздатьВедомостьПосещаемостиResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class СоздатьВедомостьПосещаемостиResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string @return;

        public СоздатьВедомостьПосещаемостиResponse()
        {
        }

        public СоздатьВедомостьПосещаемостиResponse(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ДобавитьСтудентаВВедомостьПосещаемости", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ДобавитьСтудентаВВедомостьПосещаемостиRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string GUIDVP;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        public string GUIDStudent;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> Visit;

        public ДобавитьСтудентаВВедомостьПосещаемостиRequest()
        {
        }

        public ДобавитьСтудентаВВедомостьПосещаемостиRequest(string GUIDVP, string GUIDStudent, System.Nullable<bool> Visit)
        {
            this.GUIDVP = GUIDVP;
            this.GUIDStudent = GUIDStudent;
            this.Visit = Visit;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ДобавитьСтудентаВВедомостьПосещаемостиResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ДобавитьСтудентаВВедомостьПосещаемостиResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string @return;

        public ДобавитьСтудентаВВедомостьПосещаемостиResponse()
        {
        }

        public ДобавитьСтудентаВВедомостьПосещаемостиResponse(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьДанныеОСлушателяхФЛ", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьДанныеОСлушателяхФЛRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string GUIDФизЛица;

        public ПолучитьДанныеОСлушателяхФЛRequest()
        {
        }

        public ПолучитьДанныеОСлушателяхФЛRequest(string GUIDФизЛица)
        {
            this.GUIDФизЛица = GUIDФизЛица;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьДанныеОСлушателяхФЛResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьДанныеОСлушателяхФЛResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ДанныеОСлушателеФЛ[] @return;

        public ПолучитьДанныеОСлушателяхФЛResponse()
        {
        }

        public ПолучитьДанныеОСлушателяхФЛResponse(ServiceReference1C.ДанныеОСлушателеФЛ[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьИзмененныеДанныеОФЛЗаПериод", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьИзмененныеДанныеОФЛЗаПериодRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаОт;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаДо;

        public ПолучитьИзмененныеДанныеОФЛЗаПериодRequest()
        {
        }

        public ПолучитьИзмененныеДанныеОФЛЗаПериодRequest(System.DateTime ДатаОт, System.DateTime ДатаДо)
        {
            this.ДатаОт = ДатаОт;
            this.ДатаДо = ДатаДо;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьИзмененныеДанныеОФЛЗаПериодResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьИзмененныеДанныеОФЛЗаПериодResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Состав", IsNullable = false)]
        public ServiceReference1C.ДанныеПоФизЛицу[] @return;

        public ПолучитьИзмененныеДанныеОФЛЗаПериодResponse()
        {
        }

        public ПолучитьИзмененныеДанныеОФЛЗаПериодResponse(ServiceReference1C.ДанныеПоФизЛицу[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериод", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаОт;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаДо;

        public ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодRequest()
        {
        }

        public ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодRequest(System.DateTime ДатаОт, System.DateTime ДатаДо)
        {
            this.ДатаОт = ДатаОт;
            this.ДатаДо = ДатаДо;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public ServiceReference1C.ProgramEdu[] @return;

        public ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодResponse()
        {
        }

        public ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодResponse(ServiceReference1C.ProgramEdu[] @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьGUIDФизЛицаПоТелефонуИлиПочте", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Phone;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Email;

        public ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеRequest()
        {
        }

        public ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеRequest(string Phone, string Email)
        {
            this.Phone = Phone;
            this.Email = Email;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ServiceReference1C.flGUIDs @return;

        public ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеResponse()
        {
        }

        public ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеResponse(ServiceReference1C.flGUIDs @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "СоздатьФизЛицо", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class СоздатьФизЛицоRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string ФИО;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        public string Город;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 2)]
        public string Email;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 3)]
        public string Должность;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаРождения;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 5)]
        public string Образование;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 6)]
        public string ОпытЗанятияСпортом;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 7)]
        public string МестоЖительства;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 8)]
        public string Телефон;

        public СоздатьФизЛицоRequest()
        {
        }

        public СоздатьФизЛицоRequest(string ФИО, string Город, string Email, string Должность, System.DateTime ДатаРождения, string Образование, string ОпытЗанятияСпортом, string МестоЖительства, string Телефон)
        {
            this.ФИО = ФИО;
            this.Город = Город;
            this.Email = Email;
            this.Должность = Должность;
            this.ДатаРождения = ДатаРождения;
            this.Образование = Образование;
            this.ОпытЗанятияСпортом = ОпытЗанятияСпортом;
            this.МестоЖительства = МестоЖительства;
            this.Телефон = Телефон;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "СоздатьФизЛицоResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class СоздатьФизЛицоResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public ServiceReference1C.flGUIDs @return;

        public СоздатьФизЛицоResponse()
        {
        }

        public СоздатьФизЛицоResponse(ServiceReference1C.flGUIDs @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ЗачислитьСтудента", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ЗачислитьСтудентаRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string GUIDПрограммаОбучения;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 1)]
        public string GUIDФизЛицо;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 2)]
        public string НазваниеДоговора;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 3)]
        public string НазваниеГруппы;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 4)]
        public string НазваниеПодгруппы;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаНачалаОбучения;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаОкончанияОбучения;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 7)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ДатаЗакрытияДоговора;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 8)]
        public string НазваниеПриказа;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 9)]
        public int СуммаДоговора;

        public ЗачислитьСтудентаRequest()
        {
        }

        public ЗачислитьСтудентаRequest(string GUIDПрограммаОбучения, string GUIDФизЛицо, string НазваниеДоговора, string НазваниеГруппы, string НазваниеПодгруппы, System.DateTime ДатаНачалаОбучения, System.DateTime ДатаОкончанияОбучения, System.DateTime ДатаЗакрытияДоговора, string НазваниеПриказа, int СуммаДоговора)
        {
            this.GUIDПрограммаОбучения = GUIDПрограммаОбучения;
            this.GUIDФизЛицо = GUIDФизЛицо;
            this.НазваниеДоговора = НазваниеДоговора;
            this.НазваниеГруппы = НазваниеГруппы;
            this.НазваниеПодгруппы = НазваниеПодгруппы;
            this.ДатаНачалаОбучения = ДатаНачалаОбучения;
            this.ДатаОкончанияОбучения = ДатаОкончанияОбучения;
            this.ДатаЗакрытияДоговора = ДатаЗакрытияДоговора;
            this.НазваниеПриказа = НазваниеПриказа;
            this.СуммаДоговора = СуммаДоговора;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ЗачислитьСтудентаResponse", WrapperNamespace = "http://localhost/dposervices", IsWrapped = true)]
    public partial class ЗачислитьСтудентаResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://localhost/dposervices", Order = 0)]
        public string @return;

        public ЗачислитьСтудентаResponse()
        {
        }

        public ЗачислитьСтудентаResponse(string @return)
        {
            this.@return = @return;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ПФ_ПорталДПОPortTypeChannel : ServiceReference1C.ПФ_ПорталДПОPortType, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ПФ_ПорталДПОPortTypeClient : System.ServiceModel.ClientBase<ServiceReference1C.ПФ_ПорталДПОPortType>, ServiceReference1C.ПФ_ПорталДПОPortType
    {

        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public ПФ_ПорталДПОPortTypeClient(EndpointConfiguration endpointConfiguration, string User, string Pass) :
                base(ПФ_ПорталДПОPortTypeClient.GetBindingForEndpoint(endpointConfiguration), ПФ_ПорталДПОPortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();

            ChannelFactory.Credentials.UserName.UserName = User;
            ChannelFactory.Credentials.UserName.Password = Pass;
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public ПФ_ПорталДПОPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(ПФ_ПорталДПОPortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public ПФ_ПорталДПОPortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(ПФ_ПорталДПОPortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public ПФ_ПорталДПОPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСлушателейResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьСлушателейAsync(ServiceReference1C.ПолучитьСлушателейRequest request)
        {
            return base.Channel.ПолучитьСлушателейAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСлушателейResponse> ПолучитьСлушателейAsync(System.Nullable<System.DateTime> НаДату)
        {
            ServiceReference1C.ПолучитьСлушателейRequest inValue = new ServiceReference1C.ПолучитьСлушателейRequest();
            inValue.НаДату = НаДату;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьСлушателейAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУспеваемостьResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьУспеваемостьAsync(ServiceReference1C.ПолучитьУспеваемостьRequest request)
        {
            return base.Channel.ПолучитьУспеваемостьAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУспеваемостьResponse> ПолучитьУспеваемостьAsync(System.Nullable<System.DateTime> НаДату)
        {
            ServiceReference1C.ПолучитьУспеваемостьRequest inValue = new ServiceReference1C.ПолучитьУспеваемостьRequest();
            inValue.НаДату = НаДату;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьУспеваемостьAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДоговораResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьДоговораAsync(ServiceReference1C.ПолучитьДоговораRequest request)
        {
            return base.Channel.ПолучитьДоговораAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДоговораResponse> ПолучитьДоговораAsync()
        {
            ServiceReference1C.ПолучитьДоговораRequest inValue = new ServiceReference1C.ПолучитьДоговораRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьДоговораAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОплатыResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьОплатыAsync(ServiceReference1C.ПолучитьОплатыRequest request)
        {
            return base.Channel.ПолучитьОплатыAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОплатыResponse> ПолучитьОплатыAsync()
        {
            ServiceReference1C.ПолучитьОплатыRequest inValue = new ServiceReference1C.ПолучитьОплатыRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьОплатыAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.СоздатьВедомостьResponse> ServiceReference1C.ПФ_ПорталДПОPortType.СоздатьВедомостьAsync(ServiceReference1C.СоздатьВедомостьRequest request)
        {
            return base.Channel.СоздатьВедомостьAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.СоздатьВедомостьResponse> СоздатьВедомостьAsync(string ГУИДПреподавателя, string ГУИДПрограммыОбучения, string ГУИДФормыКонтроля, string ГУИДДисциплины, System.DateTime ДатаСдачи)
        {
            ServiceReference1C.СоздатьВедомостьRequest inValue = new ServiceReference1C.СоздатьВедомостьRequest();
            inValue.ГУИДПреподавателя = ГУИДПреподавателя;
            inValue.ГУИДПрограммыОбучения = ГУИДПрограммыОбучения;
            inValue.ГУИДФормыКонтроля = ГУИДФормыКонтроля;
            inValue.ГУИДДисциплины = ГУИДДисциплины;
            inValue.ДатаСдачи = ДатаСдачи;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).СоздатьВедомостьAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ВнестиОценкиResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ВнестиОценкиAsync(ServiceReference1C.ВнестиОценкиRequest request)
        {
            return base.Channel.ВнестиОценкиAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ВнестиОценкиResponse> ВнестиОценкиAsync(ServiceReference1C.СтрокаТЧВедомости[] ОценкиВедомости, string ГУИДВедомости)
        {
            ServiceReference1C.ВнестиОценкиRequest inValue = new ServiceReference1C.ВнестиОценкиRequest();
            inValue.ОценкиВедомости = ОценкиВедомости;
            inValue.ГУИДВедомости = ГУИДВедомости;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ВнестиОценкиAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ОтправитьОценкиНаПорталResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ОтправитьОценкиНаПорталAsync(ServiceReference1C.ОтправитьОценкиНаПорталRequest request)
        {
            return base.Channel.ОтправитьОценкиНаПорталAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ОтправитьОценкиНаПорталResponse> ОтправитьОценкиНаПорталAsync(string ГУИДВедомости, string ГУИДСлушателя)
        {
            ServiceReference1C.ОтправитьОценкиНаПорталRequest inValue = new ServiceReference1C.ОтправитьОценкиНаПорталRequest();
            inValue.ГУИДВедомости = ГУИДВедомости;
            inValue.ГУИДСлушателя = ГУИДСлушателя;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ОтправитьОценкиНаПорталAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВВедомостьResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ДобавитьСтудентаВВедомостьAsync(ServiceReference1C.ДобавитьСтудентаВВедомостьRequest request)
        {
            return base.Channel.ДобавитьСтудентаВВедомостьAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВВедомостьResponse> ДобавитьСтудентаВВедомостьAsync(string ГУИДСлушателя, string ГУИДВедомости)
        {
            ServiceReference1C.ДобавитьСтудентаВВедомостьRequest inValue = new ServiceReference1C.ДобавитьСтудентаВВедомостьRequest();
            inValue.ГУИДСлушателя = ГУИДСлушателя;
            inValue.ГУИДВедомости = ГУИДВедомости;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ДобавитьСтудентаВВедомостьAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПреподавателейResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьПреподавателейAsync(ServiceReference1C.ПолучитьПреподавателейRequest request)
        {
            return base.Channel.ПолучитьПреподавателейAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПреподавателейResponse> ПолучитьПреподавателейAsync()
        {
            ServiceReference1C.ПолучитьПреподавателейRequest inValue = new ServiceReference1C.ПолучитьПреподавателейRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьПреподавателейAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьФормыКонтроляResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьФормыКонтроляAsync(ServiceReference1C.ПолучитьФормыКонтроляRequest request)
        {
            return base.Channel.ПолучитьФормыКонтроляAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьФормыКонтроляResponse> ПолучитьФормыКонтроляAsync()
        {
            ServiceReference1C.ПолучитьФормыКонтроляRequest inValue = new ServiceReference1C.ПолучитьФормыКонтроляRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьФормыКонтроляAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДисциплиныResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьДисциплиныAsync(ServiceReference1C.ПолучитьДисциплиныRequest request)
        {
            return base.Channel.ПолучитьДисциплиныAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДисциплиныResponse> ПолучитьДисциплиныAsync()
        {
            ServiceReference1C.ПолучитьДисциплиныRequest inValue = new ServiceReference1C.ПолучитьДисциплиныRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьДисциплиныAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПрограммыОбученияResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьПрограммыОбученияAsync(ServiceReference1C.ПолучитьПрограммыОбученияRequest request)
        {
            return base.Channel.ПолучитьПрограммыОбученияAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПрограммыОбученияResponse> ПолучитьПрограммыОбученияAsync()
        {
            ServiceReference1C.ПолучитьПрограммыОбученияRequest inValue = new ServiceReference1C.ПолучитьПрограммыОбученияRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьПрограммыОбученияAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьГруппыResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьГруппыAsync(ServiceReference1C.ПолучитьГруппыRequest request)
        {
            return base.Channel.ПолучитьГруппыAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьГруппыResponse> ПолучитьГруппыAsync()
        {
            ServiceReference1C.ПолучитьГруппыRequest inValue = new ServiceReference1C.ПолучитьГруппыRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьГруппыAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУровниОбразованияResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьУровниОбразованияAsync(ServiceReference1C.ПолучитьУровниОбразованияRequest request)
        {
            return base.Channel.ПолучитьУровниОбразованияAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУровниОбразованияResponse> ПолучитьУровниОбразованияAsync()
        {
            ServiceReference1C.ПолучитьУровниОбразованияRequest inValue = new ServiceReference1C.ПолучитьУровниОбразованияRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьУровниОбразованияAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьБазовыеОбразованияResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьБазовыеОбразованияAsync(ServiceReference1C.ПолучитьБазовыеОбразованияRequest request)
        {
            return base.Channel.ПолучитьБазовыеОбразованияAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьБазовыеОбразованияResponse> ПолучитьБазовыеОбразованияAsync()
        {
            ServiceReference1C.ПолучитьБазовыеОбразованияRequest inValue = new ServiceReference1C.ПолучитьБазовыеОбразованияRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьБазовыеОбразованияAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОценкиResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьОценкиAsync(ServiceReference1C.ПолучитьОценкиRequest request)
        {
            return base.Channel.ПолучитьОценкиAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОценкиResponse> ПолучитьОценкиAsync()
        {
            ServiceReference1C.ПолучитьОценкиRequest inValue = new ServiceReference1C.ПолучитьОценкиRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьОценкиAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьТипыДоговоровResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьТипыДоговоровAsync(ServiceReference1C.ПолучитьТипыДоговоровRequest request)
        {
            return base.Channel.ПолучитьТипыДоговоровAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьТипыДоговоровResponse> ПолучитьТипыДоговоровAsync()
        {
            ServiceReference1C.ПолучитьТипыДоговоровRequest inValue = new ServiceReference1C.ПолучитьТипыДоговоровRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьТипыДоговоровAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПлательщиковResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьПлательщиковAsync(ServiceReference1C.ПолучитьПлательщиковRequest request)
        {
            return base.Channel.ПолучитьПлательщиковAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьПлательщиковResponse> ПолучитьПлательщиковAsync()
        {
            ServiceReference1C.ПолучитьПлательщиковRequest inValue = new ServiceReference1C.ПолучитьПлательщиковRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьПлательщиковAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОборудованиеResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьОборудованиеAsync(ServiceReference1C.ПолучитьОборудованиеRequest request)
        {
            return base.Channel.ПолучитьОборудованиеAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьОборудованиеResponse> ПолучитьОборудованиеAsync()
        {
            ServiceReference1C.ПолучитьОборудованиеRequest inValue = new ServiceReference1C.ПолучитьОборудованиеRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьОборудованиеAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьГруппыПрограммОбученияResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьГруппыПрограммОбученияAsync(ServiceReference1C.ПолучитьГруппыПрограммОбученияRequest request)
        {
            return base.Channel.ПолучитьГруппыПрограммОбученияAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьГруппыПрограммОбученияResponse> ПолучитьГруппыПрограммОбученияAsync()
        {
            ServiceReference1C.ПолучитьГруппыПрограммОбученияRequest inValue = new ServiceReference1C.ПолучитьГруппыПрограммОбученияRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьГруппыПрограммОбученияAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьВидыПрограммResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьВидыПрограммAsync(ServiceReference1C.ПолучитьВидыПрограммRequest request)
        {
            return base.Channel.ПолучитьВидыПрограммAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьВидыПрограммResponse> ПолучитьВидыПрограммAsync()
        {
            ServiceReference1C.ПолучитьВидыПрограммRequest inValue = new ServiceReference1C.ПолучитьВидыПрограммRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьВидыПрограммAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьФормыОбученияResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьФормыОбученияAsync(ServiceReference1C.ПолучитьФормыОбученияRequest request)
        {
            return base.Channel.ПолучитьФормыОбученияAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьФормыОбученияResponse> ПолучитьФормыОбученияAsync()
        {
            ServiceReference1C.ПолучитьФормыОбученияRequest inValue = new ServiceReference1C.ПолучитьФормыОбученияRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьФормыОбученияAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСпециальностиResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьСпециальностиAsync(ServiceReference1C.ПолучитьСпециальностиRequest request)
        {
            return base.Channel.ПолучитьСпециальностиAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСпециальностиResponse> ПолучитьСпециальностиAsync()
        {
            ServiceReference1C.ПолучитьСпециальностиRequest inValue = new ServiceReference1C.ПолучитьСпециальностиRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьСпециальностиAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьТипыМероприятийResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьТипыМероприятийAsync(ServiceReference1C.ПолучитьТипыМероприятийRequest request)
        {
            return base.Channel.ПолучитьТипыМероприятийAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьТипыМероприятийResponse> ПолучитьТипыМероприятийAsync()
        {
            ServiceReference1C.ПолучитьТипыМероприятийRequest inValue = new ServiceReference1C.ПолучитьТипыМероприятийRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьТипыМероприятийAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьКвалификацииResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьКвалификацииAsync(ServiceReference1C.ПолучитьКвалификацииRequest request)
        {
            return base.Channel.ПолучитьКвалификацииAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьКвалификацииResponse> ПолучитьКвалификацииAsync()
        {
            ServiceReference1C.ПолучитьКвалификацииRequest inValue = new ServiceReference1C.ПолучитьКвалификацииRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьКвалификацииAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьВыдаваемыеДокументыResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьВыдаваемыеДокументыAsync(ServiceReference1C.ПолучитьВыдаваемыеДокументыRequest request)
        {
            return base.Channel.ПолучитьВыдаваемыеДокументыAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьВыдаваемыеДокументыResponse> ПолучитьВыдаваемыеДокументыAsync()
        {
            ServiceReference1C.ПолучитьВыдаваемыеДокументыRequest inValue = new ServiceReference1C.ПолучитьВыдаваемыеДокументыRequest();
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьВыдаваемыеДокументыAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУспеваемостьСтудентовResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьУспеваемостьСтудентовAsync(ServiceReference1C.ПолучитьУспеваемостьСтудентовRequest request)
        {
            return base.Channel.ПолучитьУспеваемостьСтудентовAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьУспеваемостьСтудентовResponse> ПолучитьУспеваемостьСтудентовAsync(string ГУИДСлушателя)
        {
            ServiceReference1C.ПолучитьУспеваемостьСтудентовRequest inValue = new ServiceReference1C.ПолучитьУспеваемостьСтудентовRequest();
            inValue.ГУИДСлушателя = ГУИДСлушателя;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьУспеваемостьСтудентовAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСлушателейПоФИОResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьСлушателейПоФИОAsync(ServiceReference1C.ПолучитьСлушателейПоФИОRequest request)
        {
            return base.Channel.ПолучитьСлушателейПоФИОAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьСлушателейПоФИОResponse> ПолучитьСлушателейПоФИОAsync(string ФИО, string НомерДиплома)
        {
            ServiceReference1C.ПолучитьСлушателейПоФИОRequest inValue = new ServiceReference1C.ПолучитьСлушателейПоФИОRequest();
            inValue.ФИО = ФИО;
            inValue.НомерДиплома = НомерДиплома;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьСлушателейПоФИОAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.СоздатьАттестационнуюВедомостьResponse> ServiceReference1C.ПФ_ПорталДПОPortType.СоздатьАттестационнуюВедомостьAsync(ServiceReference1C.СоздатьАттестационнуюВедомостьRequest request)
        {
            return base.Channel.СоздатьАттестационнуюВедомостьAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.СоздатьАттестационнуюВедомостьResponse> СоздатьАттестационнуюВедомостьAsync(string GUIDTeacher, string GUIDProgram, string GUIDFormControl, string GUIDSubject, string GUIDGroup, System.DateTime Data, string Number)
        {
            ServiceReference1C.СоздатьАттестационнуюВедомостьRequest inValue = new ServiceReference1C.СоздатьАттестационнуюВедомостьRequest();
            inValue.GUIDTeacher = GUIDTeacher;
            inValue.GUIDProgram = GUIDProgram;
            inValue.GUIDFormControl = GUIDFormControl;
            inValue.GUIDSubject = GUIDSubject;
            inValue.GUIDGroup = GUIDGroup;
            inValue.Data = Data;
            inValue.Number = Number;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).СоздатьАттестационнуюВедомостьAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВАттестационнуюВедомостьResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ДобавитьСтудентаВАттестационнуюВедомостьAsync(ServiceReference1C.ДобавитьСтудентаВАттестационнуюВедомостьRequest request)
        {
            return base.Channel.ДобавитьСтудентаВАттестационнуюВедомостьAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВАттестационнуюВедомостьResponse> ДобавитьСтудентаВАттестационнуюВедомостьAsync(string GUIDAV, string GUIDStudent, string GUIDRate, System.Nullable<bool> excellent, string comment)
        {
            ServiceReference1C.ДобавитьСтудентаВАттестационнуюВедомостьRequest inValue = new ServiceReference1C.ДобавитьСтудентаВАттестационнуюВедомостьRequest();
            inValue.GUIDAV = GUIDAV;
            inValue.GUIDStudent = GUIDStudent;
            inValue.GUIDRate = GUIDRate;
            inValue.excellent = excellent;
            inValue.comment = comment;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ДобавитьСтудентаВАттестационнуюВедомостьAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.СоздатьВедомостьПосещаемостиResponse> ServiceReference1C.ПФ_ПорталДПОPortType.СоздатьВедомостьПосещаемостиAsync(ServiceReference1C.СоздатьВедомостьПосещаемостиRequest request)
        {
            return base.Channel.СоздатьВедомостьПосещаемостиAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.СоздатьВедомостьПосещаемостиResponse> СоздатьВедомостьПосещаемостиAsync(string GUIDProgram, string GUIDSubject, string GUIDGroup, string GUIDSubGroup, System.DateTime Data)
        {
            ServiceReference1C.СоздатьВедомостьПосещаемостиRequest inValue = new ServiceReference1C.СоздатьВедомостьПосещаемостиRequest();
            inValue.GUIDProgram = GUIDProgram;
            inValue.GUIDSubject = GUIDSubject;
            inValue.GUIDGroup = GUIDGroup;
            inValue.GUIDSubGroup = GUIDSubGroup;
            inValue.Data = Data;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).СоздатьВедомостьПосещаемостиAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВВедомостьПосещаемостиResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ДобавитьСтудентаВВедомостьПосещаемостиAsync(ServiceReference1C.ДобавитьСтудентаВВедомостьПосещаемостиRequest request)
        {
            return base.Channel.ДобавитьСтудентаВВедомостьПосещаемостиAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ДобавитьСтудентаВВедомостьПосещаемостиResponse> ДобавитьСтудентаВВедомостьПосещаемостиAsync(string GUIDVP, string GUIDStudent, System.Nullable<bool> Visit)
        {
            ServiceReference1C.ДобавитьСтудентаВВедомостьПосещаемостиRequest inValue = new ServiceReference1C.ДобавитьСтудентаВВедомостьПосещаемостиRequest();
            inValue.GUIDVP = GUIDVP;
            inValue.GUIDStudent = GUIDStudent;
            inValue.Visit = Visit;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ДобавитьСтудентаВВедомостьПосещаемостиAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДанныеОСлушателяхФЛResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьДанныеОСлушателяхФЛAsync(ServiceReference1C.ПолучитьДанныеОСлушателяхФЛRequest request)
        {
            return base.Channel.ПолучитьДанныеОСлушателяхФЛAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьДанныеОСлушателяхФЛResponse> ПолучитьДанныеОСлушателяхФЛAsync(string GUIDФизЛица)
        {
            ServiceReference1C.ПолучитьДанныеОСлушателяхФЛRequest inValue = new ServiceReference1C.ПолучитьДанныеОСлушателяхФЛRequest();
            inValue.GUIDФизЛица = GUIDФизЛица;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьДанныеОСлушателяхФЛAsync(inValue);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ФизЛицо> ПолучитьДанныеПоАттестациямФЛAsync(string GUIDФизЛица)
        {
            return base.Channel.ПолучитьДанныеПоАттестациямФЛAsync(GUIDФизЛица);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ДанныеПоФизЛицу> ПолучитьДанныеОФЛAsync(string GUIDФизЛица)
        {
            return base.Channel.ПолучитьДанныеОФЛAsync(GUIDФизЛица);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьИзмененныеДанныеОФЛЗаПериодResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьИзмененныеДанныеОФЛЗаПериодAsync(ServiceReference1C.ПолучитьИзмененныеДанныеОФЛЗаПериодRequest request)
        {
            return base.Channel.ПолучитьИзмененныеДанныеОФЛЗаПериодAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьИзмененныеДанныеОФЛЗаПериодResponse> ПолучитьИзмененныеДанныеОФЛЗаПериодAsync(System.DateTime ДатаОт, System.DateTime ДатаДо)
        {
            ServiceReference1C.ПолучитьИзмененныеДанныеОФЛЗаПериодRequest inValue = new ServiceReference1C.ПолучитьИзмененныеДанныеОФЛЗаПериодRequest();
            inValue.ДатаОт = ДатаОт;
            inValue.ДатаДо = ДатаДо;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьИзмененныеДанныеОФЛЗаПериодAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодAsync(ServiceReference1C.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодRequest request)
        {
            return base.Channel.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодResponse> ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодAsync(System.DateTime ДатаОт, System.DateTime ДатаДо)
        {
            ServiceReference1C.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодRequest inValue = new ServiceReference1C.ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодRequest();
            inValue.ДатаОт = ДатаОт;
            inValue.ДатаДо = ДатаДо;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьИзмененныеДанныеОПрограммахДПОЗаПериодAsync(inValue);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ProgramEdu> ПолучитьДанныеОПрограммеAsync(string GUIDПрограммы)
        {
            return base.Channel.ПолучитьДанныеОПрограммеAsync(GUIDПрограммы);
        }

        public System.Threading.Tasks.Task<string> ПолучитьGUIDФизЛицаПоКартеИПаролюAsync(string login, string pass)
        {
            return base.Channel.ПолучитьGUIDФизЛицаПоКартеИПаролюAsync(login, pass);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(ServiceReference1C.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеRequest request)
        {
            return base.Channel.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеResponse> ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(string Phone, string Email)
        {
            ServiceReference1C.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеRequest inValue = new ServiceReference1C.ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеRequest();
            inValue.Phone = Phone;
            inValue.Email = Email;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ПолучитьGUIDФизЛицаПоТелефонуИлиПочтеAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.СоздатьФизЛицоResponse> ServiceReference1C.ПФ_ПорталДПОPortType.СоздатьФизЛицоAsync(ServiceReference1C.СоздатьФизЛицоRequest request)
        {
            return base.Channel.СоздатьФизЛицоAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.СоздатьФизЛицоResponse> СоздатьФизЛицоAsync(string ФИО, string Город, string Email, string Должность, System.DateTime ДатаРождения, string Образование, string ОпытЗанятияСпортом, string МестоЖительства, string Телефон)
        {
            ServiceReference1C.СоздатьФизЛицоRequest inValue = new ServiceReference1C.СоздатьФизЛицоRequest();
            inValue.ФИО = ФИО;
            inValue.Город = Город;
            inValue.Email = Email;
            inValue.Должность = Должность;
            inValue.ДатаРождения = ДатаРождения;
            inValue.Образование = Образование;
            inValue.ОпытЗанятияСпортом = ОпытЗанятияСпортом;
            inValue.МестоЖительства = МестоЖительства;
            inValue.Телефон = Телефон;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).СоздатьФизЛицоAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1C.ЗачислитьСтудентаResponse> ServiceReference1C.ПФ_ПорталДПОPortType.ЗачислитьСтудентаAsync(ServiceReference1C.ЗачислитьСтудентаRequest request)
        {
            return base.Channel.ЗачислитьСтудентаAsync(request);
        }

        public System.Threading.Tasks.Task<ServiceReference1C.ЗачислитьСтудентаResponse> ЗачислитьСтудентаAsync(string GUIDПрограммаОбучения, string GUIDФизЛицо, string НазваниеДоговора, string НазваниеГруппы, string НазваниеПодгруппы, System.DateTime ДатаНачалаОбучения, System.DateTime ДатаОкончанияОбучения, System.DateTime ДатаЗакрытияДоговора, string НазваниеПриказа, int СуммаДоговора)
        {
            ServiceReference1C.ЗачислитьСтудентаRequest inValue = new ServiceReference1C.ЗачислитьСтудентаRequest();
            inValue.GUIDПрограммаОбучения = GUIDПрограммаОбучения;
            inValue.GUIDФизЛицо = GUIDФизЛицо;
            inValue.НазваниеДоговора = НазваниеДоговора;
            inValue.НазваниеГруппы = НазваниеГруппы;
            inValue.НазваниеПодгруппы = НазваниеПодгруппы;
            inValue.ДатаНачалаОбучения = ДатаНачалаОбучения;
            inValue.ДатаОкончанияОбучения = ДатаОкончанияОбучения;
            inValue.ДатаЗакрытияДоговора = ДатаЗакрытияДоговора;
            inValue.НазваниеПриказа = НазваниеПриказа;
            inValue.СуммаДоговора = СуммаДоговора;
            return ((ServiceReference1C.ПФ_ПорталДПОPortType)(this)).ЗачислитьСтудентаAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ПФ_ПорталДПОSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode.TransportCredentialOnly);
                result.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.Basic;
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ПФ_ПорталДПОSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ПФ_ПорталДПОSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://217.16.28.213/1CDB_FPA_DPO/ws/dposervices.1cws");
            }
            if ((endpointConfiguration == EndpointConfiguration.ПФ_ПорталДПОSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://217.16.28.213/1CDB_FPA_DPO/ws/dposervices.1cws");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }

        public enum EndpointConfiguration
        {

            ПФ_ПорталДПОSoap,

            ПФ_ПорталДПОSoap12,
        }
    }
}