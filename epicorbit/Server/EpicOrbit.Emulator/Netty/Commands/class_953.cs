using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_953 : ICommand {

        public short ID { get; set; } = 23754;
        public int var_5275 = 0;
        public int var_1331 = 0;

        public class_953(int param1 = 0, int param2 = 0) {
            this.var_5275 = param1;
            this.var_1331 = param2;
        }

        public void Read(IDataInput param1, ICommandLookup lookup) {
            this.var_5275 = param1.ReadInt();
            this.var_5275 = param1.Shift(this.var_5275, 2);
            this.var_1331 = param1.ReadInt();
            this.var_1331 = param1.Shift(this.var_1331, 31);
            param1.ReadShort();
        }

        public void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected void method_9(IDataOutput param1) {
            param1.WriteInt(param1.Shift(this.var_5275, 30));
            param1.WriteInt(param1.Shift(this.var_1331, 1));
            param1.WriteShort(31376);
        }
    }
}
