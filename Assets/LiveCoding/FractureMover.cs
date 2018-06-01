using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiveCoding{
    public class FractureMover : MonoBehaviour {
        FracturedObject fracturedComponent;

        [Range(0.00f, 1.00f)]
        public float space  = 0.0f;

        public float _space {
            get { return space; }
            set { space = value; }
        }

        void Start () {
            fracturedComponent = this.GetComponent<FracturedObject> ();
        }

        public void ForceDecomposition(){
            if(Mathf.Equals(space, 0.0f)){
                fracturedComponent.SetSingleMeshVisibility(true);
            }
            else{
                fracturedComponent.SetSingleMeshVisibility(false);
            }

            foreach (FracturedChunk fracturedChunk in fracturedComponent.ListFracturedChunks){
                fracturedChunk.PreviewDecompositionValue = space;
                fracturedChunk.UpdatePreviewDecompositionPosition();
            }
        }

        void Update () {
            ForceDecomposition ();
        }
    }
}
