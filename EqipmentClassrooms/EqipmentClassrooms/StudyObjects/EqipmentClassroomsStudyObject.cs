//using System;
//using EqipmentClassrooms.Domain;

//namespace EqipmentClassrooms.StudyObjects
//{
//    public partial class EqipmentClassroomsStudyObjects
//    {
//        public Audience[] Audience { get; set; }
//        public AudienceEqipmentTypes[] AudienceEqipmentTypes { get; set; }
//        public AudienceType[] AudienceType { get; set; }
//        public Eqipment[] Eqipment { get; set; }
//        public EqipmentAudience[] EqipmentAudience { get; set; }
//        public EqipmentType[] EqipmentType { get; set; }

//        public EqipmentClassroomsStudyObjects()
//        {
//            CreateAudience();
//            CreateAudienceArray();
//            CreateAudienceEqipmentTypes();
//            CreateAudienceEqipmentTypesArray();
//            CreateAudienceType();
//            CreateAudienceTypeArray();
//            CreateEqipment();
//            CreateEqipmentArray();
//            CreateEqipmentAudience();
//            CreateEqipmentAudienceArray();
//            CreateEqipmentType();
//            CreateEqipmentTypeArray();
//        }
//        public Audience AB;
//        public Audience AC;
//        public Audience AD;
//        public Audience AA;
//        private void CreateAudienceArray()
//        {
//            Audience = new Audience[] {
//            AB, AC, AD,AA};
//        }

//        public AudienceEqipmentTypes TextileEqipment;
//        public AudienceEqipmentTypes ComputerEqipment;
//        public AudienceEqipmentTypes FurnitureEqipment;

//        private void CreateAudienceEqipmentTypesArray()
//        {
//            AudienceEqipmentTypes = new AudienceEqipmentTypes[] {
//               TextileEqipment,ComputerEqipment,FurnitureEqipment
//            };
//        }
//        public AudienceType ComputerAudience;
//        public AudienceType ChemistryAudience;
//        public AudienceType PhysicalAudience;
//        private void CreateAudienceTypeArray()
//        {
//            AudienceType = new AudienceType[] {
//               ComputerAudience, ChemistryAudience, PhysicalAudience
//            };
//        }
//        public Eqipment Desk;
//        public Eqipment Chair;
//        public Eqipment Board;
//        public Eqipment Carrying;
//        public Eqipment Computer;
//        public Eqipment Keyboard;
//        public Eqipment Mous;
//        public Eqipment Paper;
//        public Eqipment Marker;
//        public Eqipment Progector;

//        private void CreateEqipmentArray()
//        {
//            Eqipment = new Eqipment[] {
//               Desk, Chair, Board, Carrying, Computer,Keyboard,Mous,
//               Paper, Marker,Progector
//            };
//        }

//        public EqipmentAudience Extinguisher;
//        public EqipmentAudience EvacuationPlans;
//        public EqipmentAudience StandSafety;
//        private void CreateEqipmentAudienceArray()
//        {
//            EqipmentAudience = new EqipmentAudience[] {
//            Extinguisher, EvacuationPlans, StandSafety
//            };
//        }

//        public EqipmentType Information;
//        public EqipmentType ForWork;
//        private void CreateEqipmentTypeArray()
//        {
//            EqipmentType = new EqipmentType[] {
//                Information,ForWork
//            };
//        }
//        private void CreateAudience()
//        {
//            AB = new Audience("301", "Інформатика", null) { };
//            AC = new Audience("303", "Географія", null) { };
//            AD = new Audience("14", "Програмування", null) { };
//            AA = new Audience("16", "Англійська Мова", null);
//        }
//        private void CreateAudienceEqipmentTypes()
//        {
//            TextileEqipment = new AudienceEqipmentTypes("Текстиль", "j", "j\n")
//            {
//                NameTypeAudience = "Текстил - изделия, выработанные из гибких,\n" +
//                "мягких волокон и нитей (ткани, вата, сети и т. д.),\n" +
//                " изготавливаемые обычно из пряжи на ткацком станке.\n" +
//                "(https://ru.wikipedia.org/wiki/Текстиль)\n",
//                Note = " К текстилю относят также материю, не являющуюся тканью:\n" +
//                " трикотаж, войлок, современные нетканые материалы\n"
//            };
//            ComputerEqipment = new AudienceEqipmentTypes("ComputerEqw.", "j", "j\n")
//            {
//                Note = "Комп'ютерна техніка — пристрої та системи пристроїв,\n" +
//                "що є компонентами комп'ютера, а також самі комп'ютери та обладнання,\n" +
//                "яке працює спільно з комп'ютерами (периферійні пристрої)\n" +
//                "і забезпечує деяку додаткову функціональність (друк або сканування документів,\n" +
//                "доступ до мережі, захист від збоїв живлення тощо)."
//            };
//            FurnitureEqipment = new AudienceEqipmentTypes("Аудиторія", "j", "j\n")
//            {
//                Note = "Фурниту́ра(англ.furniture, фр.fourniture, от фр.fournir\n" +
//                " — доставлять, снабжать, нем. Beschlag) — вспомогательные части и детали,\n" +
//                "необходимые для изготовления некоего цельного предмета.\n"
//            };
//        }
//        private void CreateAudienceType()
//        {
//            ComputerAudience = new AudienceType("ComputerAud.\n")
//            {
//                Definition = "Аудиторія обладнанна компюторами\n" +
//                "для виконання на них різних поставленних задач\n",
//                Note = "В навчальних закладах зазвичай декілька компюторних аудиторій\n"
//            };
//            ChemistryAudience = new AudienceType("ChemistryAud.\n") { };
//        }
//        private void CreateEqipment()
//        {
//            Desk = new Eqipment("Доска", new DateTime(2014, 1, 1), "Рік виготовлення", null);
//            Chair = new Eqipment("Стільці", new DateTime(2010, 1, 1), "Рік виготовлення", null);
//            Board = new Eqipment("Дошка", new DateTime(2011, 1, 1), "Рік виготовлення", null);
//            Computer = new Eqipment("Компютер", new DateTime(2013, 1, 1), "Рік виготовлення", null);
//            Keyboard = new Eqipment("Клавіатура", new DateTime(2011, 1, 1), "Рік виготовлення", null);
//            Mous = new Eqipment("Мишка", new DateTime(2009, 1, 1), "Рік виготовлення", null);
//            Paper = new Eqipment("Папір", new DateTime(2017, 1, 1), "Рік виготовлення", null);
//            Marker = new Eqipment("Маркер", new DateTime(2016, 1, 1), "Рік виготовлення", null);
//            Progector = new Eqipment("Проектор", new DateTime(2013, 1, 1), "Рік виготовлення", null);
//        }
//        private void CreateEqipmentAudience()
//        {
//            Extinguisher = new EqipmentAudience("Extinguisher", "Вогнегасник\n")
//            {
//                Number = 305,
//                InventoryNumber = 31 / 3,
//                Note = "Вогнега́сник — технічний засіб, призначений для припинення горіння\n" +
//                "подаванням вогнегасної речовини, що міститься в ньому,\n" +
//                "під дією надмірного тиску, за масою і конструктивним виконанням придатний\n" +
//                "для транспортування і застосування однією людиною.\n" +
//                "(https://uk.wikipedia.org/wiki/Вогнегасник)\n"
//            };
//            EvacuationPlans = new EqipmentAudience("EvacuationPl.", "План евакуації\n")
//            {
//                Number = 305,
//                InventoryNumber = 33 / 1,
//                Note = "План эвакуации — документ, в котором указаны эвакуационные пути и выходы,\n" +
//            "установлены правила поведения людей, а также порядок и последовательность действий\n" +
//            "обслуживающего персонала на объекте при возникновении чрезвычайной ситуации.\n" +
//            "План эвакуации, знаки безопасности и указатели направления позволяют принять\n" +
//            "необходимые меры по эвакуации людей с мест\n" +
//            "массового скопления при возникновении чрезвычайных ситуаций.\n" +
//            "(https://ru.wikipedia.org/wiki/План_эвакуации)\n"
//            };
//            StandSafety = new EqipmentAudience("StandSaf.", "Стенд охорони праці\n")
//            {
//                Number = 305,
//                InventoryNumber = 35 / 10,
//                Note = "Охорóна прáці (рос. охрана труда; англ. labour protection; нім. Arbeitsschutz m) — це:\n" +
//                " система правових, соціально-економічних, організаційно-технічних,\n" +
//                "санітарно-гігієнічних і лікувально-профілактичних заходів та засобів,\n" +
//                "спрямованих на збереження життя, здоров'я і працездатності людини в процесі трудової діяльності;\n" +
//                "(https://uk.wikipedia.org/wiki/Охорона_праці)\n"
//            };
//        }
//        private void CreateEqipmentType()
//        {
//            Information = new EqipmentType("Inform", "Компютерна техніка яка допомагає з пошуком інформацї\n",
//                "Інформаційний тип\n");
//            ForWork = new EqipmentType("ForWork", "Предмети призначенні для обробки інформації вручну\n",
//                "Тип призначений для роботи\n");
//        }
//    }
//}

