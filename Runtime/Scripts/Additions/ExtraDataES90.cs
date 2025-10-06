using UnityEngine;

namespace GLTFast.Schema
{
    public class ExtraDataES90 : MonoBehaviour
    {
        public string vis_material_RG00;
        public string vis_material_RG10;
        public string vis_material_AG10;
        public string vis_material_RC00;
        public string vis_material_RC10;
        public string vis_material_AC60;
        public string vis_material_R330;

        public void Populate(Extras extras)
        {
            vis_material_RG00 = extras.vis_material_RG00;
            vis_material_RG10 = extras.vis_material_RG10;
            vis_material_AG10 = extras.vis_material_AG10;
            vis_material_RC00 = extras.vis_material_RC00;
            vis_material_RC10 = extras.vis_material_RC10;
            vis_material_AC60 = extras.vis_material_AC60;
            vis_material_R330 = extras.vis_material_R330;
        }
    }
}
