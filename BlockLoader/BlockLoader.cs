/*
 * Author: joshi1999
 */

 //V.1.0
 
using System;
using System.Net;
using System.IO;

namespace ManicDigger.Mods
{
	public class BlockLoader : IMod
	{
		public void PreStart(ModManager m)
		{

		}
		public void Start(ModManager manager)
		{
            m = manager;
            if(useUpToDateBlockIds) 
            {
			    loadBlockFile();
            }
		}

        bool useUpToDateBlockIds = true;
		
        ModManager m;
        string remoteUri = "https://raw.githubusercontent.com/joshi1999/ManicDiggerMods/master/BlockLoader/";
        string fileName = "blocks.csv";
        string dirPath = "UserData/BlockLoader/";

        public int getId(String name) 
        {
            string[] ids = System.IO.File.ReadAllLines(dirPath + fileName);
            foreach(string idComplement in ids) 
            {
                string[] pair = System.Text.RegularExpressions.Regex.Split(idComplement, ",");
                if (pair[1] == name) 
                {
                    return Int32.Parse(pair[0]);
                }
            }
            return -1;
        }

        void loadBlockFile() 
        {
            WebClient myWebClient = new WebClient();
            string blockresource = remoteUri + fileName;
            Directory.CreateDirectory(dirPath);
            try 
            {
                myWebClient.DownloadFile(blockresource, dirPath + fileName);
            }
            catch (Exception e)
            {
                m.LogServerEvent("[ERROR - BlockLoader] Could not pull updated BlockList");
            }
        }
	}
}

