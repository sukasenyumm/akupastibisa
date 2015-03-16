using Microsoft.Xna.Framework;

namespace ThesisSimulation.src.UIStates.Interfaces
{
    public interface IStateBase
    {
        void LoadContent();
        void Draw(GameTime gameTime);
        void Update(GameTime gameTime);
        void Destroy();
    }
}
