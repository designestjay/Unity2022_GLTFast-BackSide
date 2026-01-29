// Copyright 2020-2022 Andreas Atteneder
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using UnityEngine;

namespace GLTFast.Schema
{

    /// <summary>
    /// An object defining the hierarchy relations and the local transform of
    /// its content.
    /// </summary>
    [System.Serializable]
    public class Node : NamedObject
    {

        /// <summary>
        /// The indices of this node's children.
        /// </summary>
        public uint[] children;

        /// <summary>
        /// The index of the mesh in this node.
        /// </summary>
        public int mesh = -1;

        /// <summary>
        /// A floating-point 4x4 transformation matrix stored in column-major order.
        /// </summary>
        public float[] matrix;

        /// <summary>
        /// The node's unit quaternion rotation in the order (x, y, z, w),
        /// where w is the scalar.
        /// </summary>
        public float[] rotation;

        /// <summary>
        /// The node's non-uniform scale.
        /// </summary>
        public float[] scale;

        /// <summary>
        /// The node's translation.
        /// </summary>
        public float[] translation;

        // /// <summary>
        // /// The weights of the instantiated Morph Target.
        // /// Number of elements must match number of Morph Targets of used mesh.
        // /// </summary>
        // public double[] weights;

        /// <summary>
        /// </summary>
        public int skin = -1;

        /// <summary>
        /// Camera index
        /// </summary>
        public int camera = -1;

        /// <inheritdoc cref="NodeExtensions"/>
        public NodeExtensions extensions;

        public Extras extras;

        internal void GltfSerialize(JsonWriter writer)
        {
            writer.AddObject();
            GltfSerializeRoot(writer);

            if (children != null)
            {
                writer.AddArrayProperty("children", children);
            }

            if (mesh >= 0)
            {
                writer.AddProperty("mesh", mesh);
            }

            if (translation != null)
            {
                writer.AddArrayProperty("translation", translation);
            }

            if (rotation != null)
            {
                writer.AddArrayProperty("rotation", rotation);
            }

            if (scale != null)
            {
                writer.AddArrayProperty("scale", scale);
            }

            if (matrix != null)
            {
                writer.AddArrayProperty("matrix", matrix);
            }

            if (skin >= 0)
            {
                writer.AddProperty("skin", skin);
            }

            if (camera >= 0)
            {
                writer.AddProperty("camera", camera);
            }

            if (extensions != null)
            {
                writer.AddProperty("extensions");
                extensions.GltfSerialize(writer);
            }

            if (extras != null)
            {
                writer.AddProperty("extras");
                extras.GltfSeralize(writer);
            }
            writer.Close();
        }
    }

    [System.Serializable]
    public class Extras
    {
        //EX90
        public string vis_material_RD00;
        public string vis_material_R330;
        public string vis_material_RD10;
        public string vis_material_AD60;
        public string vis_material_AG60;
        public string vis_material_RG00;
        public string vis_material_RG10;

        // EX30
        public string vis_material_R220;
        public string vis_material_R540;
        public string vis_material_R430;
        public string vis_material_R310;

        // ES90
        public string vis_material_AG10;
        public string vis_material_RC00;
        public string vis_material_RC10;
        public string vis_material_AC60;

        // EX60
        public string vis_material_R690;
        public string vis_material_W3A0;
        public string vis_material_WC20;
        public string vis_material_WD20;
        public string vis_material_WG20;

        public bool AllNullEX90 ()
        {
            return vis_material_RD00 == null &&
                vis_material_R330 ==  null &&
                vis_material_RD10 == null &&
                vis_material_AD60 == null&&
                vis_material_AG60 == null &&
                vis_material_RG00 == null &&
                vis_material_RG10 == null;
        }

        public bool AllNullEX30 ()
        {
            return vis_material_R220 == null &&
                vis_material_R540 ==  null &&
                vis_material_R430 == null &&
                vis_material_R310 == null;
        }

        public bool AllNullES90 ()
        {
            return vis_material_RG00 == null &&
                vis_material_RG10 == null &&
                vis_material_AG10 == null &&
                vis_material_RC00 == null &&
                vis_material_RC10 ==  null &&
                vis_material_AC60 == null &&
                vis_material_R330 == null;
        }

        public bool AllNullEX60 ()
        {
            return vis_material_R690 == null &&
                vis_material_RC00 == null &&
                vis_material_RC10 == null &&
                vis_material_RD00 == null &&
                vis_material_RD10 == null &&
                vis_material_RG00 == null &&
                vis_material_RG10 == null &&
                vis_material_W3A0 == null &&
                vis_material_WC20 == null &&
                vis_material_WD20 == null &&
                vis_material_WG20 == null;
        }

        internal void GltfSeralize(JsonWriter writer)
        {
            Debug.Log(writer);
        }
    }

    /// <summary>
    /// Node extensions
    /// </summary>
    [System.Serializable]
    public class NodeExtensions
    {
        // Names are identical to glTF specified properties, that's why
        // inconsistent names are ignored.
        // ReSharper disable InconsistentNaming

        /// <inheritdoc cref="MeshGpuInstancing"/>
        public MeshGpuInstancing EXT_mesh_gpu_instancing;
        /// <inheritdoc cref="LightsPunctual"/>
        public NodeLightsPunctual KHR_lights_punctual;

        // Whenever an extension is added, the JsonParser
        // (specifically step four of JsonParser.ParseJson)
        // needs to be updated!

        // ReSharper restore InconsistentNaming
        internal void GltfSerialize(JsonWriter writer)
        {
            writer.AddObject();
            if (EXT_mesh_gpu_instancing != null)
            {
                writer.AddProperty("EXT_mesh_gpu_instancing");
                EXT_mesh_gpu_instancing.GltfSerialize(writer);
            }
            if (KHR_lights_punctual != null)
            {
                writer.AddProperty("KHR_lights_punctual");
                KHR_lights_punctual.GltfSerialize(writer);
            }
            writer.Close();
        }
    }
}
