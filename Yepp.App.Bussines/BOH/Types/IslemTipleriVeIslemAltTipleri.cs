using System.Collections.Generic;

namespace Yepp.App.Bussines.BOH.Types
{
    /// <summary>
    /// IslemTipleriVeIslemAltTipleri
    /// </summary>
    public static class IslemTipleriVeIslemAltTipleri
    {
        /// <summary>
        /// Islem  tipleri ve islem alt tipleri listesi.
        /// </summary>
        /// <returns></returns>
        public static List<IslemTipleri> IslemTipleriVeIslemAltTipleriListesi()
        {
            var _resultList = new List<IslemTipleri>();
            _resultList.Add(new IslemTipleri() { ProcessType = 1, ProcessTypeDesc = "Bakiye Yüklem", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 1, ProcessSubTypeDesc = "Masterpass ile Yükleme" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 1, ProcessTypeDesc = "Bakiye Yüklem", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 2, ProcessSubTypeDesc = "Hesaptan Yükleme" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 1, ProcessTypeDesc = "Bakiye Yüklem", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 3, ProcessSubTypeDesc = "VPOS ile Yükleme" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 1, ProcessTypeDesc = "Bakiye Yüklem", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 4, ProcessSubTypeDesc = "Hesaptan Hızlı Yükleme" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 1, ProcessTypeDesc = "Bakiye Yüklem", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 5, ProcessSubTypeDesc = "Cüzdandan Yükleme" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 1, ProcessTypeDesc = "Bakiye Yüklem", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 6, ProcessSubTypeDesc = "İptal ile Yükleme" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 1, ProcessTypeDesc = "Bakiye Yüklem", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 7, ProcessSubTypeDesc = "İade ile Yükleme" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 2, ProcessTypeDesc = "Bakiye Transferi", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 1, ProcessSubTypeDesc = "Cüzdandan Hesaba" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 2, ProcessTypeDesc = "Bakiye Transferi", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 2, ProcessSubTypeDesc = "Cüzdandan Cüzdana" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 2, ProcessTypeDesc = "Bakiye Transferi", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 3, ProcessSubTypeDesc = "Cüzdandan Karta" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 3, ProcessTypeDesc = "Ödeme", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 1, ProcessSubTypeDesc = "Üye İşyeri Ödemesi" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 3, ProcessTypeDesc = "Ödeme", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 2, ProcessSubTypeDesc = "Fatura Ödemesi" } });
            _resultList.Add(new IslemTipleri() { ProcessType = 4, ProcessTypeDesc = "Para Çekme", IslemAltTipleri = new IslemAltTipleri() { ProcessSubType = 1, ProcessSubTypeDesc = "Atm" } });

            return
                _resultList;
        }
    }

    /// <summary>
    /// IslemTipleri
    /// </summary>
    public class IslemTipleri
    {
        /// <summary>
        /// Gets or sets the type of the process.
        /// </summary>
        /// <value>
        /// The type of the process.
        /// </value>
        public int ProcessType { get; set; }

        /// <summary>
        /// Gets or sets the process type desc.
        /// </summary>
        /// <value>
        /// The process type desc.
        /// </value>
        public string ProcessTypeDesc { get; set; }

        /// <summary>
        /// Gets or sets the islem alt tipleri.
        /// </summary>
        /// <value>
        /// The islem alt tipleri.
        /// </value>
        public IslemAltTipleri IslemAltTipleri { get; set; }
    }

    /// <summary>
    /// IslemAltTipleri
    /// </summary>
    public class IslemAltTipleri
    {
        /// <summary>
        /// Gets or sets the type of the process sub.
        /// </summary>
        /// <value>
        /// The type of the process sub.
        /// </value>
        public int ProcessSubType { get; set; }

        /// <summary>
        /// Gets or sets the process sub type desc.
        /// </summary>
        /// <value>
        /// The process sub type desc.
        /// </value>
        public string ProcessSubTypeDesc { get; set; }
    }
}