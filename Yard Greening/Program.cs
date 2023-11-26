double squareMetres = double.Parse(Console.ReadLine());
double Price1 = squareMetres * 7.61;
double discount = Price1 * 0.18;
double finalPrice = Price1 - discount;
Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
