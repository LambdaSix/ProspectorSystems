using System.Collections.Generic;
using VRage.Game;
using VRage.ModAPI;
using VRageMath;

namespace ProspectorSystems.Data.Script
{
    public class MiningInformation
    {
        public MyVoxelMaterialDefinition Material;
        public Vector3D Location;
        public IMyVoxelBase Voxel;
        public List<Vector3D> Positions;
    }

    public class MiningInformationPB
    {
        public MyVoxelMaterialDefinition Material;
        public Vector3D Location;
        public IMyVoxelBase Voxel;
        public ulong Count;

        public MiningInformationPB(MiningInformation mi)
        {
            Material = mi.Material;
            Location = mi.Location;
            Voxel = mi.Voxel;
            Count = (ulong)mi.Positions.Count;
        }
    }

    public enum OreDetectorMode : int
    {
        Unknown = 0,
        Detection = 1,
        Scanning = 2,
        Prospecting = 3
    }
}
