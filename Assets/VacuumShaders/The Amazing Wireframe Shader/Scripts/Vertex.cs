//using UnityEngine;
//using System.Collections.Generic;

//namespace VacuumShaders
//{
//    namespace TheAmazingWireframeShader
//    {
//        struct Vertex : IEquatable<Vertex>
//        {
//            public long x, y, z;

//            const int scaleFactor = 100000;

//            public Vertex(Vector3 _v)
//            {
//                x = (long)(_v.x * scaleFactor);
//                y = (long)(_v.y * scaleFactor);
//                z = (long)(_v.z * scaleFactor);
//            }

//            public Vector3 vector3
//            {
//                get
//                {
//                    return new Vector3(x, y, z) / scaleFactor;
//                }
//            }

//            public override int GetHashCode()
//            {
//                //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode

//                unchecked // Overflow is fine, just wrap
//                {
//                    int hash = 17;
//                    // Suitable nullity checks etc, of course :)
//                    hash = hash * 23 + x.GetHashCode();
//                    hash = hash * 23 + y.GetHashCode();
//                    hash = hash * 23 + z.GetHashCode();
//                    return hash;
//                }
//            }

//            public bool Equals(Vertex p)
//            {
//                return x == p.x && y == p.y && z == p.z;
//            }

//            //public override bool Equals(object obj)
//            //{
//            //    // If parameter is null return false.
//            //    if (obj == null)
//            //    {
//            //        return false;
//            //    }

//            //    // If parameter cannot be cast to Point return false.
//            //    Vertex p = obj as Vertex;
//            //    if ((System.Object)p == null)
//            //    {
//            //        return false;
//            //    }

//            //    //Check reference equality
//            //    if (ReferenceEquals(this, obj))
//            //        Debug.LogWarning("ReferenceEquals: " + this.ToString() + " -> " + obj.ToString());


//            //    // Return true if the fields match:
//            //    return x == p.x && y == p.y && z == p.z;
//            //}

//            //public override int GetHashCode()
//            //{
//            //    return x.GetHashCode() + y.GetHashCode() + z.GetHashCode();
//            //}

//            //public static bool operator ==(Vertex a, Vertex b)
//            //{
//            //    // If both are null, or both are same instance, return true.
//            //    if (System.Object.ReferenceEquals(a, b))
//            //    {
//            //        return true;
//            //    }

//            //    // If one is null, but not both, return false.
//            //    if (((object)a == null) || ((object)b == null))
//            //    {
//            //        return false;
//            //    }

//            //    // Return true if the fields match:
//            //    return a.x == b.x && a.y == b.y && a.z == b.z;
//            //}

//            //public static bool operator !=(Vertex a, Vertex b)
//            //{
//            //    return !(a == b);
//            //}

//            //public static Vector3 operator -(Vertex a, Vertex b)
//            //{
//            //    Vector3 v1 = a.vector3;
//            //    Vector3 v2 = b.vector3;

//            //    return v1 - v2;
//            //}

//            //public override string ToString()
//            //{
//            //    return vector3.ToString();
//            //}

//        }

//    }
//}

