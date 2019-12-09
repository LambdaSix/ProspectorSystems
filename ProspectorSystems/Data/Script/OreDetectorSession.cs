using VRage.Game.Components;

namespace ProspectorSystems.Data.Script
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    class OreDetectorSession : MySessionComponentBase
    {
        private OreDetector m_oreDetector = OreDetector.Instance;
        public OreDetector OreDetector { get { return m_oreDetector; } }
        protected override void UnloadData()
        {
            base.UnloadData();
            m_oreDetector = null;
            OreDetector.UnloadStatic();
        }

        public override void UpdateAfterSimulation()
        {
            base.UpdateAfterSimulation();
        }
    }
}
