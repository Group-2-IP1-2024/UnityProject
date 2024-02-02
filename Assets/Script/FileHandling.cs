using UnityEngine;
using MEC;
using YamlDotNet;
using YamlDotNet.Serialization;
using System.Collections.Generic;
using Assets.Script;
using YamlDotNet.Serialization.NamingConventions;

namespace Script
{
    public class FileHandling : MonoBehaviour
    {
        public ISerializer _serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
        public IDeserializer _deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
        public static List<string> PatientNames = new List<string>();
        public static List<Enums.Illness> Illnesses = new List<Enums.Illness>();
        void Awake()
        {
            ReadNames();
            ReadIllnesses();
        }

        /*public void InitFiles()
        {
            string path1 = Application.dataPath + "/Resources/PatientNames.txt";
            string path2 = Application.dataPath + "/Resources/Illnesses.txt";
            PatientNames.Add("Morty Smith");
            PatientNames.Add("Rick Sanchez");
            Illnesses.Add(new Enums.Illness { Name = "Cancer", Description = "Cancer is a group of diseases involving abnormal cell growth with the potential to invade or spread to other parts of the body.", Symptoms = new string[] { "Swelling of lymph nodes", "Fever", "Shortness of breath", "Persistent fatigue"}, Treatment = new string[] { "Chemotherapy", "Radiotherapy" } });
            Illnesses.Add(new Enums.Illness { Name = "Diabetes", Description = "Diabetes mellitus (DM), commonly known as diabetes, is a group of metabolic disorders characterized by a high blood sugar level over a prolonged period of time.", Symptoms = new string[] { "Increased thirst", "Frequent urination", "Increased hunger" }, Treatment = new string[] { "Insulin", "Metformin" } });
            try
            {
                System.IO.File.WriteAllText(path1, _serializer.Serialize(PatientNames));
                System.IO.File.WriteAllText(path2, _serializer.Serialize(Illnesses));
            }
            catch (System.Exception e)
            {
                Debug.Log(e);
            }
        }*/

        public void ReadNames()
        {
            string path = Application.dataPath + "/Resources/PatientNames.txt";
            try
            {
                PatientNames = _deserializer.Deserialize<List<string>>(System.IO.File.ReadAllText(path));
            }
            catch (System.Exception e)
            {
                Debug.Log(e);
            }
        }

        public void ReadIllnesses()
        {
            string path = Application.dataPath + "/Resources/Illnesses.txt";
            try
            {
                Illnesses = _deserializer.Deserialize<List<Enums.Illness>>(System.IO.File.ReadAllText(path));
            }
            catch (System.Exception e)
            {
                Debug.Log(e);
            }
        }
    }
}