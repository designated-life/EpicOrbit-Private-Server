using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_592 : class_543, ICommand {

        public override short ID { get; set; } = 24524;
        public string userName = "";

        public class_592(string param1 = "") {
            this.userName = param1;
        }

        public override void Read(IDataInput param1, ICommandLookup lookup) {
            base.Read(param1, lookup);
            this.userName = param1.ReadUTF();
            param1.ReadShort();
            param1.ReadShort();
        }

        public override void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected override void method_9(IDataOutput param1) {
            base.method_9(param1);
            param1.WriteUTF(this.userName);
            param1.WriteShort(-30541);
            param1.WriteShort(31924);
        }
    }
}
