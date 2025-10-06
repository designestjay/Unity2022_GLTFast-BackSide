using UnityEngine;

namespace GLTFast.Schema
{
    public class ExtraDataEX30 : MonoBehaviour
    {
        public string vis_material_R220;
        public string vis_material_R540;
        public string vis_material_R430;
        public string vis_material_R310;

        public void Populate (Extras extras)
        {
            vis_material_R220 = extras.vis_material_R220;
            vis_material_R540 = extras.vis_material_R540;
            vis_material_R430 = extras.vis_material_R430;
            vis_material_R310 = extras.vis_material_R310;
        }
    }
}