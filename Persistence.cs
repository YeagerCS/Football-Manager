using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Football_Manager
{
    public class Persistence
    {
        private readonly string filename = "serialization\\manager.json";
        private readonly string filenamePlayers = "serialization\\players.json";
        private readonly string filenameBench = "serialization\\bench.json";
        private readonly string filenameShop = "serialization\\shop.json";
        private readonly string filenameTeam = "serialization\\team.json";
        private readonly string filenameTeams = "serialization\\entity.json";
        private readonly string filenameMatches = "serialization\\matches.json";
        private readonly JsonSerializer serializer;

        public Persistence()
        {
            serializer = new JsonSerializer();
        }

        public Manager LoadManagers()
        {
            Manager managers = new Manager();
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                managers = JsonConvert.DeserializeObject<Manager>(json);
            }
            return managers;
        }

        public void SaveManagers(Manager managers)
        {
            string json = JsonConvert.SerializeObject(managers, Formatting.Indented);
            File.WriteAllText(filename, json);
        }

        public List<Player> LoadPlayersStarting()
        {
            List<Player> players = new List<Player>();
            if (File.Exists(filenamePlayers))
            {
                string json = File.ReadAllText(filenamePlayers);
                players = JsonConvert.DeserializeObject<List<Player>>(json);
            }
            return players;
        }

        public void SavePlayersStarting(List<Player> players)
        {
            string json = JsonConvert.SerializeObject(players, Formatting.Indented);
            File.WriteAllText(filenamePlayers, json);
        }

        //////////////////////////////////
        public List<Player> LoadPlayersBench()
        {
            List<Player> players = new List<Player>();
            if (File.Exists(filenameBench))
            {
                string json = File.ReadAllText(filenameBench);
                players = JsonConvert.DeserializeObject<List<Player>>(json);
            }
            return players;
        }

        public void SavePlayersbench(List<Player> players)
        {
            string json = JsonConvert.SerializeObject(players, Formatting.Indented);
            File.WriteAllText(filenameBench, json);
        }

        //////////////////////////////////
        public List<Player> LoadPlayerShop()
        {
            List<Player> players = new List<Player>();
            if (File.Exists(filenameShop))
            {
                string json = File.ReadAllText(filenameShop);
                players = JsonConvert.DeserializeObject<List<Player>>(json);
            }
            return players;
        }

        public void SavePlayerShop(List<Player> players)
        {
            string json = JsonConvert.SerializeObject(players, Formatting.Indented);
            File.WriteAllText(filenameShop, json);
        }
        //////////////////////////////////

        public Team LoadTeam()
        {
            Team team = new Team();
            if (File.Exists(filenameTeam))
            {
                string json = File.ReadAllText(filenameTeam);
                team = JsonConvert.DeserializeObject<Team>(json);
            }
            return team;
        }

        public void SaveTeam(Team team)
        {
            string json = JsonConvert.SerializeObject(team, Formatting.Indented);
            File.WriteAllText(filenameTeam, json);
        }

        //////////////////////////////////
        public List<Team> LoadEntityTeams()
        {
            List<Team> players = new List<Team>();
            if (File.Exists(filenameTeams))
            {
                string json = File.ReadAllText(filenameTeams);
                players = JsonConvert.DeserializeObject<List<Team>>(json);
            }
            return players;
        }

        public void SaveEntityTeams(List<Team> players)
        {
            string json = JsonConvert.SerializeObject(players, Formatting.Indented);
            File.WriteAllText(filenameTeams, json);
        }

        //////////////////////////////////
        public List<string> LoadMatches()
        {
            List<string> players = new List<string>();
            if (File.Exists(filenameMatches))
            {
                string json = File.ReadAllText(filenameMatches);
                players = JsonConvert.DeserializeObject<List<string>>(json);
            }
            return players;
        }

        public void SaveMatches(List<string> players)
        {
            string json = JsonConvert.SerializeObject(players, Formatting.Indented);
            File.WriteAllText(filenameMatches, json);
        }
    }
}