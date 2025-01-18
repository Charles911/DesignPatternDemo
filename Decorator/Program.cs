using Decorator;

var phone = new ApplePhone();

var applePhoneWithSticker = new Sticker(phone);
applePhoneWithSticker.Print();
Console.WriteLine("-------------------------");

var applePhoneWithAccessories = new Accessories(phone);
applePhoneWithAccessories.Print();
Console.WriteLine("-------------------------");

var sticker = new Sticker(phone);
var applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
applePhoneWithAccessoriesAndSticker.Print();