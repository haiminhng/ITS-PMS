using Azure;
using Microsoft.IdentityModel.Tokens;

namespace Models.Models.utilities
{
    /**
  * Repräsentiert ein Eintrag (d.h. eine Unterrichtsstunde) aus dem GP Untis
  * Export "aktueller Unterricht für einen Lehrer".
  *
  * @author Oliver Schwahlen
  * @version 1.0
  */
    public class UntisStunde
    {
        /**
       * Lehrerkurzzeichen
       */

        private string _kurzzeichen;
        public string Kurzzeichen
        {
            get
            {
                string tmpKurzzeichen = "";
                string[] split = this._kurzzeichen.Split(", ");

                foreach (var strKurz in split)
                {
                    tmpKurzzeichen = tmpKurzzeichen + strKurz.ToUpper().ElementAt(0) + strKurz.ToLower().Substring(1) + ", ";
                }

                tmpKurzzeichen = tmpKurzzeichen.Substring(0, tmpKurzzeichen.Length - 2);
                return tmpKurzzeichen;
            }
            set { _kurzzeichen = value; }
        }
        
        
        /**
    * Jahr der Unterrichtsstunde
*/
        private int _jahr;

        /**
    * Monat der Unterrichtsstunde
*/
        private int _monat;

        /**
    * Tag der Unterrichtsstunde
*/
        private int _tag;

        /**
    * Nummer der Unterrichtsstunde
*/
        private int _schulstunde;

        /**
    * Kurzname des Fachs der Unterrichtsstunde
*/
        private string _fach;

        /**
    * Kurzname der Klasse (oder der Klassen mit ~ getrennt), in der die
    * Unterrichtsstunde abgehalten wird
*/
        private string _klasse;

        /**
    * Kurzname des Raums, in dem die Unterrichtsstunde gehalten wird
*/
        private string _raum;

        /**
    * Bezahlung der Vertretung (0...unbezahlt; 1...bezahlt)
*/
        private int _bezahlung;

        /**
    * Fachgruppe (44211) der Unterrichtsstunde
*/
        private string _fachgruppe;

        /**
    * Beginnzeit (Zeitstunde) der Unterrichtsstunde
*/
        private int _stunde;

        /**
    * Beginnzeit (Zeitminute) der Unterrichtsstunde
*/
        private int _minute;

        /**
    * Dauer (in Minuten) der Unterrichtsstunde
*/
        private int _dauer;
        public DateTime StundeBegin
        {
            get
            {
                return new DateTime(_jahr, _monat, _tag, _stunde, _minute, 0);
            }
        }

        public DateTime StundeEnde
        {
            get
            {
                return StundeBegin.AddMinutes(_dauer);
            }
        }

        public string KlassenNames
        {
            get
            {
                return _klasse;
            }
        }

        public UntisStunde(string zeile, string trennzeichen)
        {
            string[] tmpDaten = zeile.Split(trennzeichen);
            try
            {
                this._kurzzeichen = tmpDaten[0];
                this._jahr = Int32.Parse(tmpDaten[1]);
                this._monat = Int32.Parse(tmpDaten[2]);
                this._tag = Int32.Parse(tmpDaten[3]);
                this._schulstunde = Int32.Parse(tmpDaten[4]);
                this._fach = tmpDaten[5];
                this._klasse = tmpDaten[6];
                this._raum = tmpDaten[7].Length == 4
                    ? tmpDaten[7].Substring(0, 1) + "." + tmpDaten[7].Substring(1)
                    : tmpDaten[7];
                this._raum = (this._raum.IsNullOrEmpty() ? "unbekannt" : this._raum);
                this._bezahlung = Int32.Parse(tmpDaten[8]);
                // tmpDaten[9] ist leer
                this._fachgruppe = tmpDaten[10];
                this._stunde = Int32.Parse(tmpDaten[11].Substring(0, tmpDaten[11].Length - 2));
                this._minute = Int32.Parse(tmpDaten[11].Substring(tmpDaten[11].Length - 2, tmpDaten[11].Length));
                this._dauer = Int32.Parse(tmpDaten[12]);
            }
            catch (Exception e)
            {
            }
        }

        public override string ToString()
        {
            return this._kurzzeichen + " " + this._jahr + "/" + this._monat + "/" + this._tag + ":" + this._schulstunde;
        }
    }
}
