using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_741 : ICommand {

        public short ID { get; set; } = 27693;
        public int name_33 = 0;

        public class_741(int param1 = 0) {
            this.name_33 = param1;
        }

        public void Read(IDataInput param1, ICommandLookup lookup) {
            this.name_33 = param1.ReadInt();
            this.name_33 = param1.Shift(this.name_33, 18);
            param1.ReadShort();
        }

        public void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected void method_9(IDataOutput param1) {
            param1.WriteInt(param1.Shift(this.name_33, 14));
            param1.WriteShort(29805);
        }
    }
}
