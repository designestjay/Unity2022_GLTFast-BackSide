using UnityEngine;

namespace GLTFast.Schema
{
    public class ExtraData : MonoBehaviour
    {
        public string vis_material_AD60;
        public string vis_material_R330;
        public string vis_material_RD00;
        public string vis_material_RD10;
        public string vis_material_AG60;
        public string vis_material_RG00;
        public string vis_material_RG10;

        //ES90
        public string vis_material_AG10;
        public string vis_material_RC00;
        public string vis_material_RC10;
        public string vis_material_AC60;

        public void Populate (Extras extras)
        {
            vis_material_AD60 = extras.vis_material_AD60;
            vis_material_R330 = extras.vis_material_R330;
            vis_material_RD00 = extras.vis_material_RD00;
            vis_material_RD10 = extras.vis_material_RD10;
            vis_material_AG60 = extras.vis_material_AG60;
            vis_material_RG00 = extras.vis_material_RG00;
            vis_material_RG10 = extras.vis_material_RG10;

            //ES90
            vis_material_AG10 = extras.vis_material_AG10;
            vis_material_RC00 = extras.vis_material_RC00;
            vis_material_RC10 = extras.vis_material_RC10;
            vis_material_AC60 = extras.vis_material_AC60;
        }
    }
}