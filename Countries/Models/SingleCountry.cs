namespace Countries.Models;

public class Rootobject
{
    public At at { get; set; }
}

public class At
{
    public string? name { get; set; }
    public string? official_name { get; set; }
    public string?[] topLevelDomain { get; set; }
    public string? alpha2Code { get; set; }
    public string? alpha3Code { get; set; }
    public string? cioc { get; set; }
    public string? numericCode { get; set; }
    public string? callingCode { get; set; }
    public string? capital { get; set; }
    public string?[] altSpellings { get; set; }
    public string? region { get; set; }
    public string? subregion { get; set; }
    public int population { get; set; }
    public Latlng latLng { get; set; }
    public Demonyms demonyms { get; set; }
    public int area { get; set; }
    public Gini gini { get; set; }
    public string?[] timezones { get; set; }
    public string?[] borders { get; set; }
    public Nativenames nativeNames { get; set; }
    public Currencies currencies { get; set; }
    public Languages languages { get; set; }
    public Translations translations { get; set; }
    public Flag flag { get; set; }
    public Regionalbloc[] regionalBlocs { get; set; }
}

public class Latlng
{
    public float[] country { get; set; }
    public float[] capital { get; set; }
}

public class Demonyms
{
    public Eng eng { get; set; }
    public Fra fra { get; set; }
}

public class Eng
{
    public string f { get; set; }
    public string m { get; set; }
}

public class Fra
{
    public string f { get; set; }
    public string m { get; set; }
}

public class Gini
{
    public float _2018 { get; set; }
}

public class Nativenames
{
    public Bar bar { get; set; }
}

public class Bar
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Currencies
{
    public EUR EUR { get; set; }
}

public class EUR
{
    public string name { get; set; }
    public string symbol { get; set; }
}

public class Languages
{
    public string bar { get; set; }
}

public class Translations
{
    public string ara { get; set; }
    public string ces { get; set; }
    public string cym { get; set; }
    public string deu { get; set; }
    public string est { get; set; }
    public string fin { get; set; }
    public string fra { get; set; }
    public string hrv { get; set; }
    public string hun { get; set; }
    public string ita { get; set; }
    public string jpn { get; set; }
    public string kor { get; set; }
    public string nld { get; set; }
    public string per { get; set; }
    public string pol { get; set; }
    public string por { get; set; }
    public string rus { get; set; }
    public string slk { get; set; }
    public string spa { get; set; }
    public string swe { get; set; }
    public string urd { get; set; }
    public string zho { get; set; }
}

public class Flag
{
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
}

public class Regionalbloc
{
    public string acronym { get; set; }
    public string name { get; set; }
}
