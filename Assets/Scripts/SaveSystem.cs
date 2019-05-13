using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(CharacterMov player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerr.lol";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPLayer()
    {
        string path = Application.persistentDataPath + "/playerr.lol";
        if (File.Exists(path))
        {
            BinaryFormatter form = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);

            PlayerData data = form.Deserialize(fs) as PlayerData;
            fs.Close();
            return data;
        }
        else
        {
            Debug.LogError("File not found in " + path);
            return null;
        }
    }
}
