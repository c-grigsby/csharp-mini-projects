namespace AttributePractice
{
  public class Address
  {
    public string Street { get; set; }
    public string ApartmentNumber { get; set; }
    public string City { get; set; }

    public string State { get; set; }
    [NoJson]
    public int Zip { get; set; }

    public Address(string street, string city, string state, int zip)
    {
      this.Street = street;
      this.City = city;
      this.State = state;
      this.Zip = zip;
    }
    public Address(string street, string aptNum, string city, string state, int zip)
    {
      this.Street = street;
      this.ApartmentNumber = aptNum;
      this.City = city;
      this.State = state;
      this.Zip = zip;
    }

    public override string ToString()
    {
      return $"Street: {Street}\nApt Number: {ApartmentNumber}\nCity: {City}\nState: {State}\nZip: {Zip}\n";
    }
  }
}