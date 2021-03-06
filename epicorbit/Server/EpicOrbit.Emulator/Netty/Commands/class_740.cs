using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_740 : ICommand {

        // DebuggingServerShipPositionCommand
        // HeroMoveCommand
        // PetGearLocatorUpdate

        public short ID { get; set; } = 9905;
        public int y = 0;
        public int x = 0;

        public class_740(int param1 = 0, int param2 = 0) {
            this.x = param1;
            this.y = param2;
        }

        public void Read(IDataInput param1, ICommandLookup lookup) {
            this.y = param1.ReadInt();
            this.y = param1.Shift(this.y, 30);
            this.x = param1.ReadInt();
            this.x = param1.Shift(this.x, 30);
        }

        public void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected void method_9(IDataOutput param1) {
            param1.WriteInt(param1.Shift(this.y, 2));
            param1.WriteInt(param1.Shift(this.x, 2));
        }
    }
}
