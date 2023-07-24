class program
{
	static void Main(string[] args)
	{
		DateTime data1 = new DateTime(2023, 07, 24);
		DateTime data2 = new DateTime(2023, 07, 24, 15, 30, 50);
		Console.WriteLine(data1);
		Console.WriteLine(data2);
		Console.WriteLine(DateTime.Now); //Data e Horário Local.
		Console.WriteLine(DateTime.UtcNow); //Horário Mundial.
		Console.WriteLine(DateTime.Today); //Apenas data local.
		Console.WriteLine(data2.Minute); //Pega apenas o ano, mes, dia, minuto ou segundo.
		Console.WriteLine(data1.DayOfYear); //Retorna o dia do ano, ou dia da semana "Dayofweek".

		//Operações com DateTime
		DateTime data3 = data1.AddDays(10);

		DateTime data4 = data1.AddYears(2);
		Console.WriteLine(data3);

		TimeSpan a = data4.Subtract(data1);
		Console.WriteLine(a.Days);

		DateTime datanascimento = new DateTime(2003, 12, 11);
		TimeSpan diasvividos = data1.Subtract(datanascimento);
		Console.WriteLine(diasvividos);

		Console.WriteLine("Informe sua data de nascimento.");
		DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());
		Console.WriteLine(dataNasc.DayOfWeek);

		//0 - datas iguais
		//-1 a primeira data é anterior a segunda
		//1 a primeira data é posterior a segunda
		Console.WriteLine(DateTime.Compare(data1,data2));

	}
}

