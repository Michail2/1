int a = Convert.ToInt32(Console.ReadLine());
int last = Convert.ToInt32(a.ToString()
                            .AsEnumerable()
                            .Last()
                            .ToString());
Console.WriteLine(last);