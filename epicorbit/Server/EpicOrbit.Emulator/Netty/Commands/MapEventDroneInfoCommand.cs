using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class MapEventDroneInfoCommand : ICommand {

        public short ID { get; set; } = 19457;
        public bool simple = false;
        public string legacyDroneCommandString = "";

        public MapEventDroneInfoCommand(bool param1 = false, string param2 = "") {
            this.simple = param1;
            this.legacyDroneCommandString = param2;
        }

        public void Read(IDataInput param1, ICommandLookup lookup) {
            this.simple = param1.ReadBoolean();
            this.legacyDroneCommandString = param1.ReadUTF();
            param1.ReadShort();
        }

        public void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected void method_9(IDataOutput param1) {
            param1.WriteBoolean(this.simple);
            param1.WriteUTF(this.legacyDroneCommandString);
            param1.WriteShort(28061);
        }
    }
}
