public class User
{

	private int userID;
	private string password;
	private string name;
	private string type;

	public int getUserID()
	{
		return this.userID;
	}

	public void setUserID(int value)
	{
		this.userID = value;
	}

	public string getPassword()
	{
		return this.password;
	}

	public void setPassword(string value)
	{
		this.password = value;
	}

	public string getName()
	{
		return this.name;
	}

	public void setName(string value)
	{
		this.name = value;
	}

	public string getType()
	{
		return this.type;
	}

	public void setType(string value)
	{
		this.type = value;
	}

}