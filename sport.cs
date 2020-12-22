using System;

namespace sports
{
    public class SportBall : ISportType
{
	int players;
	string sport;
	SportCategory _type;
	double Len;
	double Wdt;

	public SportBall(int nbr, SportCategory tp, string name)
	{
		players = nbr;
		_type = tp;
		sport = name;
	}

	public int NumberOfPlayers
	{
		get { return players; }
		set { players = value; }
	}

	public string NameOfSport
	{
		get { return sport; }
	}

	public SportCategory Type
	{
		get { return _type; }
	}

	public double Length
	{
		get { return Len; }
		set { Len = value; }
	}

	public double Width
	{
		get { return Wdt; }
		set { Wdt = value; }
	}

	public void SportCharacteristics()
	{
		Console.WriteLine("Sport Characteristics");
		Console.WriteLine("Name of Sport: {0}", NameOfSport);
		Console.WriteLine("Type of Sport: {0}", Type);
		Console.WriteLine("# of Players:  {0}", NumberOfPlayers);
		Console.WriteLine("Court Dimensions: {0}m x {1}m", Len, Wdt);
	}
}
class Program
{
	static void Main()
	{
		SportBall volley = new SportBall(6, SportCategory.Collective, "Volley Ball");
		volley.Length = 18;
		volley.Width = 9;
		volley.SportCharacteristics();

		Console.WriteLine();

		SportBall tennis = new SportBall(1, SportCategory.SinglePlayer, "Table Tennis");
		tennis.Length = 23.7;
		tennis.Width = 8.25;
		tennis.SportCharacteristics();

		Console.WriteLine();
	}
}
}
