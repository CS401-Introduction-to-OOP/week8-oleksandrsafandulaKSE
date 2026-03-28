
using Week8;

var letter1 = new Letter("1", 1.1);
var letter2 = new Letter("2", 1.2);

var parcel = new Parcel("3", 4.2);

letter1.PrintInfo();

var myCargo = new CargoContainer<DeliveryItemBase>();

myCargo.AddItem(letter1);
myCargo.AddItem(letter2);
myCargo.AddItem(parcel);

Console.WriteLine(myCargo.GetTotalCost());