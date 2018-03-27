using EqipmentClassrooms.Domain;
using System;
//using EqipmentClassrooms.StudyObjects;
//using EqipmentClassrooms.StudyObjects;

namespace EqipmentClassrooms.Data
{
    partial class EqipmentClassroomsDataSet
    {
        public void CreateMinTestData()
        {
            //var objects = new EqipmentClassroomsStudyObjects();
            //foreach (Audience obj in objects.Audience)
            //{
            //    Audiencess.Add(obj);
            //}
            //foreach (AudienceEqipmentTypes obj in objects.AudienceEqipmentTypes)
            //{
            //    AudienceEqipmentTypes.Add(obj);
            //}
            //foreach (AudienceType obj in objects.AudienceType)
            //{
            //    AudienceTypess.Add(obj);
            //}
            //foreach (Eqipment obj in objects.Eqipment)
            //{
            //    Eqipmentss.Add(obj);
            //}
            //foreach (EqipmentAudience obj in objects.EqipmentAudience)
            //{
            //    EqipmentAudiencess.Add(obj);

            //}
            //foreach (EqipmentType obj in objects.EqipmentType)
            //{
            //    EqipmentTypess.Add(obj);
            //}
            //var objects = new EqipmentClassroomsStudyObjects();
            //CreateAudienceEqipmentTypess();
            //CreateAudiences();
            //CreateAudienceTypes();
            //CreateEqipments();
            //CreateEqipmentAudiences();
            //CreateEqipmentTypes();

        }

    public void CreateTestData()
        {
            CreateMinTestData();
            CreateAudiences();
            CreateAudienceEqipmentTypess();
            CreateAudienceTypes();
            CreateEqipments();
            CreateEqipmentAudiences();
            CreateEqipmentTypes();
           
        }

        private void CreateAudiences()
        {
            Audiencess.Add(new Audience("Математика", "Математична аудиторія", 301)
            {
                Note = "Математична аудиторія -- призначена для заняття уроками математики, вищої математики"
            });
            Audiencess.Add(new Audience("Інформатика", "компюторна аудиторія", 302)
            {
                Note = "Компюторна аудиторія -- обладнана компюторами які звязані між собою,\n" +
                " і призначенні для виконання ознаюмлення з ними або проведення лабораторних робіт"
            });
            Audiencess.Add(new Audience("Географія", "Географічна аудиторія", 105)
            {
                Note = "Географічна аудиторія -- призначена для заняття урокоми географії,\n" +
                " обладнанна різним географічним обладнанням"
            });
            Audiencess.Add(new Audience("Фізика", "фізична аудиторія", 210)
            {
                Note = "Фізична аудиторія  -- призначена для проведення лабораторних робіт\n" +
                " та вивчення фізики обладнанна різними приладами"
            });
            Audiencess.Add(new Audience("Англ. мова", "Іноземна аудиторія", 407)
            {
                Note = "Аудиторія англ мови -- "
            });
        }


        //private void CreateAudiences()
        //{
        //    //Audiences.Add(new Audience("301", "Інформатика", "о") { });
        //    //Audiences.Add(new Audience("303", "Географія", "о") { });
        //    //Audiences.Add(new Audience("14", "Програмування", "о") { });
        //    //Audiences.Add(new Audience("16", "Англійська Мова", "о"));
        //}
        private void CreateAudienceEqipmentTypess()
        {
            AudienceEqipmentTypes.Add(new AudienceEqipmentTypes("Текстиль", "текстильне обладнання", "всі типи аудиторій\n")
            {
                Note = "Текстил - изделия, выработанные из гибких,\n" +
                "мягких волокон и нитей (ткани, вата, сети и т. д.),\n" +
                " изготавливаемые обычно из пряжи на ткацком станке.\n" +
                "(https://ru.wikipedia.org/wiki/Текстиль)\n"
                + " К текстилю относят также материю, не являющуюся тканью:\n" +
                " трикотаж, войлок, современные нетканые материалы\n"
            });
            AudienceEqipmentTypes.Add(new AudienceEqipmentTypes("ComputerEqw.", "Компютерне обладнання", "компютерна аудеторія\n")
            {
                Note = "Комп'ютерна техніка — пристрої та системи пристроїв,\n" +
                "що є компонентами комп'ютера, а також самі комп'ютери та обладнання,\n" +
                "яке працює спільно з комп'ютерами (периферійні пристрої)\n" +
                "і забезпечує деяку додаткову функціональність (друк або сканування документів,\n" +
                "доступ до мережі, захист від збоїв живлення тощо)."
            });
            AudienceEqipmentTypes.Add(new AudienceEqipmentTypes("Фурнітура","Мебельний тип" , "всі типи аудиторій\n")
            {
                Note = "Фурниту́ра(англ.furniture, фр.fourniture, от фр.fournir\n" +
                " — доставлять, снабжать, нем. Beschlag) — вспомогательные части и детали,\n" +
                "необходимые для изготовления некоего цельного предмета.\n"
            });
        }
        private void CreateAudienceTypes()
        {
            AudienceTypess.Add(new AudienceType("ComputerAud.")
            {
                Definition = "Аудиторія обладнанна компюторами\n" +
                "для виконання на них різних поставленних зада\n",
                Note = "В навчальних закладах зазвичай декілька компюторних аудиторій\n"
            });
            AudienceTypess.Add(new AudienceType("ChemistryAud.") {
                Definition = "Аудиторія обладнанна компюторами" +
                "для виконання на них різних поставленних задач",
                Note = "В навчальних закладах зазвичай декілька компюторних аудиторій\n"
            });
        }

        private void CreateEqipments()
        {
            Eqipmentss.Add(new Eqipment("Доска", new DateTime(2014, 1, 1), "Функциональная или спец мебель", null));
            Eqipmentss.Add(new Eqipment("Стільці", new DateTime(2010, 1, 1), "Функциональная или спец мебель", null));
            Eqipmentss.Add(new Eqipment("Дошка", new DateTime(2011, 1, 1), "Функциональная или спец мебель",null));
            Eqipmentss.Add(new Eqipment("Компютер", new DateTime(2013, 1, 1), "Система отображения графической информации", null));
            Eqipmentss.Add(new Eqipment("Клавіатура", new DateTime(2011, 1, 1), "Система отображения графической информации", null));
            Eqipmentss.Add(new Eqipment("Маркер", new DateTime(2016, 1, 1), "Функциональная или спец мебель", null));
            Eqipmentss.Add(new Eqipment("Проектор", new DateTime(2013, 1, 1), "Система отображения графической информации", null));
        }
        private void CreateEqipmentAudiences()
        {
            EqipmentAudiencess.Add(new EqipmentAudience("Extinguisher", "Вогнегасник")
            {
                Number1 = 305,
                InventoryNumber = 31 / 3,
                Note = "Вогнега́сник — технічний засіб, призначений для припинення горіння" +
                "подаванням вогнегасної речовини, що міститься в ньому,\n" +
                "під дією надмірного тиску, за масою і конструктивним виконанням придатний" +
                "для транспортування і застосування однією людиною." +
                "(https://uk.wikipedia.org/wiki/Вогнегасник)"
            });
            EqipmentAudiencess.Add(new EqipmentAudience("EvacuationPl.", "План евакуації")
            {
                Number1 = 305,
                InventoryNumber = 33 / 1,
                Note = "/nПлан эвакуации — документ, в котором указаны эвакуационные пути и выходы," +
            "установлены правила поведения людей, а также порядок и последовательность действий" +
            "обслуживающего персонала на объекте при возникновении чрезвычайной ситуации.\n" +
            "План эвакуации, знаки безопасности и указатели направления позволяют принять\n" +
            "необходимые меры по эвакуации людей с мест\n" +
            "массового скопления при возникновении чрезвычайных ситуаций.\n" +
            "(https://ru.wikipedia.org/wiki/План_эвакуации)"
            });
            EqipmentAudiencess.Add(new EqipmentAudience("StandSaf.", "Стенд охорони праці\n")
            {
                Number1 = 305,
                InventoryNumber = 35 / 10,
                Note = "Охорóна прáці (рос. охрана труда; англ. labour protection; нім. Arbeitsschutz m) — це:\n" +
                " система правових, соціально-економічних, організаційно-технічних,\n" +
                "санітарно-гігієнічних і лікувально-профілактичних заходів та засобів,\n" +
                "спрямованих на збереження життя, здоров'я і працездатності людини в процесі трудової діяльності;\n" +
                "(https://uk.wikipedia.org/wiki/Охорона_праці)\n"
            });
        }
        private void CreateEqipmentTypes()
        {
            EqipmentTypess.Add(new EqipmentType("Inform", "Компютерна техніка яка допомагає з пошуком інформацї",
                "Інформаційний тип\n"));
            EqipmentTypess.Add(new EqipmentType("ForWork", "Предмети призначенні для обробки інформації вручну",
                "Тип призначений для роботи\n"));
        }
    }
}
