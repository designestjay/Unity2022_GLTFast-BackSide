using UnityEngine;

namespace GLTFast.Schema
{
    public class ExtraDataEX60 : MonoBehaviour
    {
        // EX60 Interior Material Options
        public string vis_material_R690;  // textile_structuredknit_midnightblue
        public string vis_material_RC00;  // leather_agnesperforatedround_charcoalsolid
        public string vis_material_RC10;  // leather_agnesperforatedround_cardamom
        public string vis_material_RD00;  // vinyl_microtech_charcoalsolid
        public string vis_material_RD10;  // vinyl_microtech_cardamom
        public string vis_material_RG00;  // vinyl_microtechperforateddiagonal_charcoalsolid
        public string vis_material_RG10;  // vinyl_microtechperforateddiagonal_cardamom
        public string vis_material_W3A0;  // textile_wool_ryefogmelange
        public string vis_material_WC20;  // leather_agnesperforatedround_dawn
        public string vis_material_WD20;  // vinyl_microtech_dawn
        public string vis_material_WG20;  // vinyl_microtechperforateddiagonal_dawn

        public void Populate(Extras extras)
        {
            vis_material_R690 = extras.vis_material_R690;
            vis_material_RC00 = extras.vis_material_RC00;
            vis_material_RC10 = extras.vis_material_RC10;
            vis_material_RD00 = extras.vis_material_RD00;
            vis_material_RD10 = extras.vis_material_RD10;
            vis_material_RG00 = extras.vis_material_RG00;
            vis_material_RG10 = extras.vis_material_RG10;
            vis_material_W3A0 = extras.vis_material_W3A0;
            vis_material_WC20 = extras.vis_material_WC20;
            vis_material_WD20 = extras.vis_material_WD20;
            vis_material_WG20 = extras.vis_material_WG20;
        }
    }
}
