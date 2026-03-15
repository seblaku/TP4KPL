using System.Collections.Generic;

public class KodePos
{
    public string GetKodePos(string kelurahan)
    {
        Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
        {
            { "Batununggal", "40266" },
            { "Kujangsari",  "40287" },
            { "Mengger",     "40267" },
            { "Wates",       "40256" },
            { "Cijaura",     "40287" },
            { "Jatisari",    "40286" },
            { "Margasari",   "40286" },
            { "Sekejati",    "40286" },
            { "Kebonwaru",   "40272" },
            { "Maleer",      "40274" }
        };

        if (tabelKodePos.TryGetValue(kelurahan, out string kodePos))
            return kodePos;
        else
            return "Kode pos tidak ditemukan";
    }
}