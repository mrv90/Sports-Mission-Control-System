﻿using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using System.Collections.Generic;

namespace smcs.backend.data.access
{
    internal class DbSupplier
    {
        readonly SmcsContext cntx;

        public DbSupplier(SmcsContext cntx)
        {
            this.cntx = cntx;
        }

        internal void SeedDbWithInitalData()
        {
            var all_ranks = new List<Rank>
            {
                new Rank("س‌وظ", "سرباز0 وظیفه", "سرباز‌ وظیفه"),
                new Rank("س‌وظ", "سرباز۲ وظیفه", "سرباز‌ وظیفه"),
                new Rank("س‌وظ", "سرباز۱ وظیفه", "سرباز‌ وظیفه"),
                new Rank("س‌وظ", "سرجوخه وظیفه",    "سرباز‌ وظیفه"),

                new Rank("گ۳وظ", "گروهبان۳ وظیفه", "درجه‌دار وظیفه"),
                new Rank("گ۲وظ", "گروهبان۲ وظیفه", "درجه‌دار وظیفه"),
                new Rank("گ۱وظ", "گروهبان۱ وظیفه", "درجه‌دار وظیفه"),

                new Rank("س۳وظ", "ستوان۳ وظیفه", "افسر وظیفه"),
                new Rank("س۲وظ", "ستوان۲ وظیفه", "افسر وظیفه"),
                new Rank("س۱وظ", "ستوان۱ وظیفه", "افسر وظیفه"),

                new Rank("گ۳پ", "گروهبان۳ پایور", "درجه‌دار پایور"),
                new Rank("گ۲پ", "گروهبان۲ پایور", "درجه‌دار پایور"),
                new Rank("گ۱پ", "گروهبان۱ پایور", "درجه‌دار پایور"),
                new Rank("اس۲پ", "استوار۲ پایور", "درجه‌دار پایور"),
                new Rank("اس۱پ", "استوار۱ پایور", "درجه‌دار پایور"),

                new Rank("س۳پ", "ستوان۳ پایور",  "افسر پایور"),
                new Rank("س۲پ", "ستوان۲ پایور",  "افسر پایور"),
                new Rank("س۱پ", "ستوان۱ پایور",  "افسر پایور"),
                new Rank("سروان", "سروان",   "افسر پایور"),

                new Rank("سرگرد", "سرگرد", "افسر ارشد"),
                new Rank("سرهنگ۲", "سرهنگ۲", "افسر ارشد"),
                new Rank("سرهنگ‌تمام", "سرهنگ‌تمام", "افسر ارشد"),
            };
            this.cntx.Rank.AddRange(all_ranks);

            var all_units = new List<Unit>
            {
                new Unit("ل16"),
                new Unit("ل28"),
                new Unit("ل21"),
                new Unit("ل30"),
                new Unit("ل81"),
                new Unit("ل92"),
                new Unit("ل84"),
                new Unit("يگان موشکي"),
                new Unit("گ33"),
                new Unit("مرا02"),
                new Unit("گ11"),
                new Unit("مرا01"),
                new Unit("ل58"),
                new Unit("تی35"),
                new Unit("گ500"),
                new Unit("گ55"),
                new Unit("اداره بهی"),
                new Unit("تی36"),
                new Unit("مرازرهی"),
                new Unit("گ402"),
                new Unit("گ411"),
                new Unit("گ401"),
                new Unit("تی37"),
                new Unit("تی25"),
                new Unit("مدتب"),
                new Unit("تی45"),
                new Unit("مرا05"),
                new Unit("تی72"),
                new Unit("دااف"),
                new Unit("گ404"),
                new Unit("پش ق نزاجا"),
                new Unit("مرا08"),
                new Unit("تی71"),
                new Unit("گ422"),
                new Unit("آجا"),
                new Unit("ق ع شمال‌شرق"),
                new Unit("تی65"),
                new Unit("ف آمادوپش"),
                new Unit("ل77"),
                new Unit("ل23"),
                new Unit("مراپ"),
                new Unit("مرا04"),
                new Unit("تی41"),
                new Unit("گ44"),
                new Unit("مراتو"),
                new Unit("ل88"),
                new Unit("گ99"),
                new Unit("مرامهن"),
                new Unit("مراپش"),
                new Unit("مرامخ"),
                new Unit("مرا03"),
                new Unit("ف مهن"),
                new Unit("گ 228"),
                new Unit("ق جنوب"),
                new Unit("ل64"),
                new Unit("تی55"),
                new Unit("تی40"),
                new Unit("مراتکاور"),
                new Unit("گ22"),
                new Unit("تی38"),
                new Unit("هوانیروز"),
                new Unit("اع س نزاجا"),
                new Unit("گد840"),
                new Unit("مرا07"),
                new Unit("مرابهی"),
                new Unit("آ.ن"),
                new Unit("ق ع غرب"),
                new Unit("سماجا"),
                new Unit("معاونت طرح وبرنامه نزاجا"),
                new Unit("ق ع جنوب شرق"),
                new Unit("ق شمالشرق"),
                new Unit("بهینه سازی"),
                new Unit("ق شمالغرب"),
                new Unit("تي316"),
                new Unit("سازمان ايثارگران"),
                new Unit("تی281"),
                new Unit("هوانيروز ب"),
                new Unit("تي292"),
                new Unit("تي321"),
                new Unit("تي388"),
                new Unit("ق ع جنوب غرب"),
                new Unit("تي216"),
                new Unit("تي228"),
                new Unit("تي258"),
                new Unit("تي328"),
                new Unit("مرا 06"),
                new Unit("تي184"),
                new Unit("تي164"),
                new Unit("تي392"),
                new Unit("تي123"),
                new Unit("ساع‌س آجا"),
                new Unit("تي288"),
                new Unit("تي130"),
                new Unit("تي264"),
                new Unit("تي284"),
                new Unit("تي277"),
                new Unit("تي177"),
                new Unit("گ840"),
                new Unit("پش م 5"),
                new Unit("ستاد نزاجا"),
                new Unit("گروه پهپاد"),
                new Unit("پش م 4"),
                new Unit("تي221"),
                new Unit("تي223"),
                new Unit("تي116"),
                new Unit("تي121"),
                new Unit("۱۵۸"),
                new Unit("۱۹۲"),
                new Unit("۲۳۰"),
                new Unit("۲۵"),
                new Unit("ف آماد پش م6 ج غرب"),
                new Unit("تي364"),
                new Unit("تي181"),
                new Unit("ف آماد پش م1"),
                new Unit("تي188"),
                new Unit("تي192"),
                new Unit("تي128"),
                new Unit("پش م شمال غرب"),
                new Unit("پش م غ"),
                new Unit("گ433"),
                new Unit("تي158"),
                new Unit("پش م 3"),
                new Unit("تي377"),
                new Unit("تي230"),
                new Unit("گ444"),
                new Unit("ف ترابري"),
                new Unit("پش م 2"),
                new Unit("پش م 1"),
                new Unit("پش م 6"),
                new Unit("ف آماد پش م 5"),
                new Unit("ق ع تاکتيکي 88"),
                new Unit("قرارگاه پدافند هوايي خاتم الانبيا"),
                new Unit("ف آماد و پش(پش م3)"),
                new Unit("ق م جنوب غرب"),
                new Unit("گ455"),
                new Unit("ف آماد وپش(م.ت.ت)"),
                new Unit("مراپ(مرکز آموزش علوم و فنون)"),
                new Unit("سازمان تحقيقات و جهاد خود کفايي"),
                new Unit("نيروي هوايي"),
                new Unit("سازمان مهندسي و اجرائيات"),
                new Unit("شهيد زر هرن")
            };
            this.cntx.Unit.AddRange(all_units);

            var all_sports = new List<Sports>
            {
                new Sports("اسکي"),
                new Sports("اسکيت"),
                new Sports("بسکتبال"),
                new Sports("بوکس"),
                new Sports("تيراندازي"),
                new Sports("تکواندو"),
                new Sports("تنيس روي ميز"),
                new Sports("کوه نوردي"),
                new Sports("جوجيتسو"),
                new Sports("جهت يابي"),
                new Sports("جودو"),
                new Sports("فوتبال"),
                new Sports("فوتسال"),
                new Sports("فوتبال نزاجا"),
                new Sports("باستاني"),
                new Sports("واليبال"),
                new Sports("وزنه برداري"),
                new Sports("ووشو"),
                new Sports("کاراته"),
                new Sports("سه گانه"),
                new Sports("سوارکاري"),
                new Sports("شمشيربازي"),
                new Sports("شنا"),
                new Sports("دوچرخه سواري"),
                new Sports("دووميداني"),
                new Sports("دو صحرانوردي"),
                new Sports("موتورسواري"),
                new Sports("کيک بوکسينگ"),
                new Sports("کبدي"),
                new Sports("کونگفو"),
                new Sports("پنجگانه"),
                new Sports("پاورليفتينگ"),
                new Sports("هندبال"),
                new Sports("قايقراني"),
                new Sports("آمادگي جسماني"),
                new Sports("دارت"),
                new Sports("تنيس ارضي"),
                new Sports("کشتي آزاد"),
                new Sports("کشتي فرنگي"),
                new Sports("بدمينتون"),
                new Sports("متفرقه"),
                new Sports("بيليارد"),
                new Sports("دفاع شخصي"),
                new Sports("چوگان"),
                new Sports("دوگانه"),
                new Sports("واترپلو"),
                new Sports("چتربازي"),
                new Sports("پزشکي"),
                new Sports("شيرجه"),
                new Sports("سپکتاکرا"),
                new Sports("تير و کمان"),
                new Sports("خبرنگار و عکاس ورزشي"),
                new Sports("نجات غريق")
            };
            this.cntx.Sports.AddRange(all_sports);

            var all_offices = new List<Office>
            {
                new Office("آمادگي جسماني"),
                new Office("اسکي"),
                new Office("اسکيت هاکي"),
                new Office("باستاني"),
                new Office("بدمينتون"),
                new Office("بسکتبال"),
                new Office("بنانيه"),
                new Office("بوکس"),
                new Office("پاورليفتينگ"),
                new Office("پنجگانه"),
                new Office("تدارکات اميد"),
                new Office("تدارکات تيراندازي"),
                new Office("تدارکات جوانان"),
                new Office("تدارکات فوتسال"),
                new Office("تدارکات نوجوانان"),
                new Office("تدارکات نيرو"),
                new Office("تدارکات هندبال"),
                new Office("تنيس ارضي"),
                new Office("تنيس روي ميز"),
                new Office("تير و کمان"),
                new Office("تيراندازي"),
                new Office("تيراندازي(مراتکاور)"),
                new Office("تکواندو"),
                new Office("جهت‌يابي"),
                new Office("جودو"),
                new Office("حاوابه"),
                new Office("دارت"),
                new Office("داوران فوتبال"),
                new Office("دايره مسابقات"),
                new Office("دژبان"),
                new Office("دفاع شخصي"),
                new Office("دو صحرانوردي"),
                new Office("دوچرخه‌سواري"),
                new Office("دوگانه"),
                new Office("دووميداني"),
                new Office("روابط"),
                new Office("سه‌گانه"),
                new Office("سوارکاري"),
                new Office("شماره 1 - آموزش"),
                new Office("شماره 1 - امور باشگاه"),
                new Office("شماره 1 - مالي"),
                new Office("شماره 1 - باشگاه"),
                new Office("شماره 2 - اجراييات"),
                new Office("شماره1"),
                new Office("شماره2"),
                new Office("شماره2 - مديريت"),
                new Office("شماره2 - انبار"),
                new Office("شماره2 - آرايشگاه"),
                new Office("شماره2 - آشپزخانه"),
                new Office("شماره2 - اداري"),
                new Office("شماره2 - استخر"),
                new Office("شماره2 - بهداري"),
                new Office("شماره2 - روابط عمومي"),
                new Office("شماره2 - زمين‌چمن"),
                new Office("شماره2 - سالن چند منظوره"),
                new Office("شماره2 - سالن‌وزنه"),
                new Office("شماره2 - سوارکاري"),
                new Office("شماره2 - طرح پژوهش"),
                new Office("شماره2 - عقيدتي"),
                new Office("شماره2 - گروهان"),
                new Office("شماره2 - مهندسي"),
                new Office("شماره2 - موتورآب"),
                new Office("شنا"),
                new Office("شيرجه"),
                new Office("فوتبال آجا و ن.م"),
                new Office("فوتبال آماد"),
                new Office("فوتبال اميد"),
                new Office("فوتبال جوانان"),
                new Office("فوتبال عقيدتي"),
                new Office("فوتبال نزاجا"),
                new Office("فوتبال نيرو"),
                new Office("فوتسال"),
                new Office("قايقراني"),
                new Office("قرارگاه غرب"),
                new Office("گروهان ورزش"),
                new Office("مامور"),
                new Office("مامور خريد"),
                new Office("متفرقه"),
                new Office("موتورسواري"),
                new Office("نجات غريق"),
                new Office("هندبال"),
                new Office("هندبال نزاجا"),
                new Office("هندبال هوانيروز"),
                new Office("هيات همگاني"),
                new Office("واترپلو"),
                new Office("والیبال"),
                new Office("وزنه برداري"),
                new Office("کاراته"),
                new Office("کبدي"),
                new Office("کشتي آزاد"),
                new Office("کشتي فرنگي")
            };
            this.cntx.Office.AddRange(all_offices);

            var all_signs = new List<Signature>
            {
                new Signature("مدیر تربیت‌بدنی نزاجا", "سرهنگ ستاد محمود محمدخانی"),
                new Signature("رئیس دایره مسابقات", "سرهنگ۲ شهرام جوکار"),
                new Signature("ف گر ورزش", "ستواندوم مرتضی فتحی")
            };
            this.cntx.Signature.AddRange(all_signs);
            var sa = new User("PowerUser", "sa", "Hamid123");
            this.cntx.User.Add(sa);

            cntx.SaveChanges();
        }
    }
}
