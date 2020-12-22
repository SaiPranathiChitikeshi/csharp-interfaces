public enum SportCategory
{
	SinglePlayer,
	Collective,
	Unknown
}

public interface ICourtDimensions
{
	double Length { get; set; }
	double Width { get; set; }
}

public interface IBall
{
	int NumberOfPlayers
	{
		get;
		set;
	}

	string NameOfSport
	{
		get;
	}

	void SportCharacteristics();
}

public interface ISportType : IBall, ICourtDimensions
{
	SportCategory Type
	{
		get;
	}
}