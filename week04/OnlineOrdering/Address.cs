using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOfProvince;
    private string _country;

    public Address(string street, string city, string stateOfProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOfProvince = stateOfProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateOfProvince}\n{_country}";
    }
}
