using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_862 : class_505, ICommand {

        public override short ID { get; set; } = 13530;

        public class_862() {
        }

        public override void Read(IDataInput param1, ICommandLookup lookup) {
            base.Read(param1, lookup);
            param1.ReadShort();
            param1.ReadShort();
        }

        public override void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected override void method_9(IDataOutput param1) {
            base.method_9(param1);
            param1.WriteShort(-26936);
            param1.WriteShort(3232);
        }
    }
}
