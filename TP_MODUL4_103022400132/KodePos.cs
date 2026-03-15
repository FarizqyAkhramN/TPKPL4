using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari",  "40287"},
        {"Mengger",     "40267"},
        {"Wates",       "40256"},
        {"Cijaura",     "40287"},
        {"Jatisari",    "40286"},
        {"Margasari",   "40286"},
        {"Sekejati",    "40286"},
        {"Kebonwaru",   "40272"},
        {"Maleer",      "40274"},
        {"Samoja",      "40273"}
    };
    public string getKodePos(string kelurahan)
    {
        if (tabelKodePos.ContainsKey(kelurahan))
            return tabelKodePos[kelurahan];
        return "Data tidak ditemukan";
    }
    public string getKelurahan(string kode)
    {
        foreach (var entry in tabelKodePos)
        {
            if (entry.Value == kode)
            {
                return entry.Key;
            }
        }
        return "Kode Pos tidak ditemukan";
    }
}