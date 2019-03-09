using System.Collections.Generic;
using System.Text;

public static class PBNParser
{
    /*
	public static List<PBNGame> ReadPBN(InputStream pbnFile) {
		// TODO:
		// Open file
		// Read lines
		// Split lines into PBN-Games
		return null;
	}
	*/

    public static StringBuilder WritePBN(List<PBNGame> games)
    {
        StringBuilder pbn = new StringBuilder();
        foreach (PBNGame g in games)
        {
            PBNGameMapper.AppendGame(pbn, g);
        }
        return pbn;
    }
}
