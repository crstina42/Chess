using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class GameState
    {
        public Board Board { get; }
        public Player CurrentPlayer { get; private set; }
        public Socket socket { get; private set; }
        public GameState(Player player,Board board, string ip, int port, bool server) { 
            CurrentPlayer=player;
            Board=board;
            if(server)
            {
                //create server socket
            }else
            {
                //create client socket
            }
        }

        public void MakeMove(Move move)
        {
            socket.Send(new byte[] { });
        }
    }
}
