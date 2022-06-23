namespace NavisworksReport
{
    public class ClashResultStatusHelper
    {
        public static string ToRus(string eng)
        {
            switch (eng)
            {
                case "new":
                    return "Создать";
                case "active":
                    return "Активн.";
                case "reviewed":
                    return "Проанализировано";
                case "approved":
                    return "Подтверждено";
                case "resolved":
                    return "Исправлено";
                default:
                    return "Создать";
            }
        }

        public static string ToEng(string rus)
        {
            switch (rus)
            {
                case "Создать":
                    return "new";
                case "Активн.":
                    return "active";
                case "Проанализировано":
                    return "reviewed";
                case "Подтверждено":
                    return "approved";
                case "Исправлено":
                    return "resolved";
                default:
                    return "new";
            }
        }
    }
}
