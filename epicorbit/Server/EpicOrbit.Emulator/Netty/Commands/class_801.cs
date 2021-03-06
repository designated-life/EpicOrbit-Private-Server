using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_801 : class_607, ICommand {

        public override short ID { get; set; } = 19818;
        public bool var_246 = false;

        public class_801(bool param1 = false) {
            this.var_246 = param1;
        }

        public override void Read(IDataInput param1, ICommandLookup lookup) {
            base.Read(param1, lookup);
            this.var_246 = param1.ReadBoolean();
        }

        public override void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected override void method_9(IDataOutput param1) {
            base.method_9(param1);
            param1.WriteBoolean(this.var_246);
        }
    }
}
