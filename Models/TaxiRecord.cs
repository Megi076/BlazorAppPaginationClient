namespace BlazorAppPaginationClient.Models
{
    public class TaxiRecord
    {
        public string medallion { get; set; } = string.Empty; // Број на лиценцата
        public string hashLicense { get; set; } = string.Empty; // Хеш од лицето + лиценцата
        public DateTime pickupTime { get; set; } // Време на подигнување
        public DateTime dropOffTime { get; set; } // Време на симнување
        public int duration { get; set; } // Времетраење во секунди
        public float distance { get; set; } // Растојание во милји
        public float pLongitude { get; set; } // Географска должина на појдовната точка
        public float pLatitude { get; set; } // Географска ширина на појдовната точка
        public float dLongitude { get; set; } // Географска должина на дојдовната точка
        public float dLatitude { get; set; } // Географска ширина на дојдовната точка
        public string paymentType { get; set; } = string.Empty; // Тип на плаќање (кеш, картичка, не познато)
        public float fareAmount { get; set; } // Основа цена во USD
        public float surcharge { get; set; } // Доплата во USD
        public float tax { get; set; } // Данок во USD
        public float tipAmount { get; set; } // Бакшиш во USD
        public float tollsAmount { get; set; } // Такси за патишта во USD
        public float totalAmount { get; set; } // Вкупен износ во USD
    }
}
