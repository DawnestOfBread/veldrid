using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Veldrid;
using Veldrid.Utilities;

namespace Veldrid.NeoDemo
{
    public static partial class PrimitiveShapes
    {
        public static MeshData Plane(int width, int height, int uvUnit)
        {
            float halfWidth = width / 2;
            float halfHeight = height / 2;

            Vector2 uvScale = new(width / uvUnit, height / uvUnit);

            VertexPositionNormalTexture[] vertices =
            [
                new(new Vector3(-halfWidth, 0, -halfHeight), Vector3.UnitY, new Vector2(0, 0) * uvScale),
                new(new Vector3(halfWidth, 0, -halfHeight), Vector3.UnitY, new Vector2(1, 0) * uvScale),
                new(new Vector3(halfWidth, 0, halfHeight), Vector3.UnitY, new Vector2(1, 1) * uvScale),
                new(new Vector3(-halfWidth, 0, halfHeight), Vector3.UnitY, new Vector2(0, 1) * uvScale)
            ];

            ushort[] indices = [0, 1, 2, 0, 2, 3];

            return new SimpleMeshDataProvider(vertices, indices);
        }

        internal static MeshData Box(float width, float height, float depth, float uvUnit)
        {
            float halfWidth = width / 2;
            float halfHeight = height / 2;
            float halfDepth = depth / 2;

            Vector2 uvScale = new(width / uvUnit, height / uvUnit);

            VertexPositionNormalTexture[] vertices =
            [
                // Top
                new(new Vector3(-halfWidth, +halfHeight, -halfDepth), new Vector3(0,1,0),     new Vector2(0, 0) * uvScale),
                new(new Vector3(+halfWidth, +halfHeight, -halfDepth), new Vector3(0,1,0),     new Vector2(1, 0) * uvScale),
                new(new Vector3(+halfWidth, +halfHeight, +halfDepth), new Vector3(0,1,0),     new Vector2(1, 1) * uvScale),
                new(new Vector3(-halfWidth, +halfHeight, +halfDepth), new Vector3(0,1,0),     new Vector2(0, 1) * uvScale),
                // Bottom                                                             
                new(new Vector3(-halfWidth,-halfHeight, +halfDepth),  new Vector3(0,-1,0),    new Vector2(0, 0) * uvScale),
                new(new Vector3(+halfWidth,-halfHeight, +halfDepth),  new Vector3(0,-1,0),    new Vector2(1, 0) * uvScale),
                new(new Vector3(+halfWidth,-halfHeight, -halfDepth),  new Vector3(0,-1,0),    new Vector2(1, 1) * uvScale),
                new(new Vector3(-halfWidth,-halfHeight, -halfDepth),  new Vector3(0,-1,0),    new Vector2(0, 1) * uvScale),
                // Left                                                               
                new(new Vector3(-halfWidth, +halfHeight, -halfDepth), new Vector3(-1,0,0),    new Vector2(0, 0) * uvScale),
                new(new Vector3(-halfWidth, +halfHeight, +halfDepth), new Vector3(-1,0,0),    new Vector2(1, 0) * uvScale),
                new(new Vector3(-halfWidth, -halfHeight, +halfDepth), new Vector3(-1,0,0),    new Vector2(1, 1) * uvScale),
                new(new Vector3(-halfWidth, -halfHeight, -halfDepth), new Vector3(-1,0,0),    new Vector2(0, 1) * uvScale),
                // Right                                                              
                new(new Vector3(+halfWidth, +halfHeight, +halfDepth), new Vector3(1,0,0),     new Vector2(0, 0) * uvScale),
                new(new Vector3(+halfWidth, +halfHeight, -halfDepth), new Vector3(1,0,0),     new Vector2(1, 0) * uvScale),
                new(new Vector3(+halfWidth, -halfHeight, -halfDepth), new Vector3(1,0,0),     new Vector2(1, 1) * uvScale),
                new(new Vector3(+halfWidth, -halfHeight, +halfDepth), new Vector3(1,0,0),     new Vector2(0, 1) * uvScale),
                // Back                                                               
                new(new Vector3(+halfWidth, +halfHeight, -halfDepth), new Vector3(0,0,-1),    new Vector2(0, 0) * uvScale),
                new(new Vector3(-halfWidth, +halfHeight, -halfDepth), new Vector3(0,0,-1),    new Vector2(1, 0) * uvScale),
                new(new Vector3(-halfWidth, -halfHeight, -halfDepth), new Vector3(0,0,-1),    new Vector2(1, 1) * uvScale),
                new(new Vector3(+halfWidth, -halfHeight, -halfDepth), new Vector3(0,0,-1),    new Vector2(0, 1) * uvScale),
                // Front                                                              
                new(new Vector3(-halfWidth, +halfHeight, +halfDepth), new Vector3(0,0,1),     new Vector2(0, 0) * uvScale),
                new(new Vector3(+halfWidth, +halfHeight, +halfDepth), new Vector3(0,0,1),     new Vector2(1, 0) * uvScale),
                new(new Vector3(+halfWidth, -halfHeight, +halfDepth), new Vector3(0,0,1),     new Vector2(1, 1) * uvScale),
                new(new Vector3(-halfWidth, -halfHeight, +halfDepth), new Vector3(0,0,1),     new Vector2(0, 1) * uvScale)
            ];

            ushort[] indices =
            [
                0,1,2, 0,2,3,
                4,5,6, 4,6,7,
                8,9,10, 8,10,11,
                12,13,14, 12,14,15,
                16,17,18, 16,18,19,
                20,21,22, 20,22,23
            ];

            return new SimpleMeshDataProvider(vertices, indices);
        }
    }
}
