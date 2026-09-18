using Microsoft.Xna.Framework;
using MinigameFramework.Enums;
using MinigameFramework.Render;

namespace MinigameFramework.Entities
{
    public class Entity
    {
        /// <summary>
		/// <see cref="IEntity">IEntity's</see> anchor, or position.
		/// </summary>
		protected Vector2 _anchor;

        /// <summary>
        /// <see cref="IEntity">IEntity's</see> <see cref="IDrawer"/> for rendering.
        /// </summary>
        protected IDrawer _drawer;

        /// <summary>
        /// <see cref="IEntity">IEntity's</see> entering <see cref="Transition"/>.
        /// </summary>
        protected IFilter _enteringTransition;

        /// <summary>
        /// <see cref="IEntity">IEntity's</see> exiting <see cref="Transition"/>.
        /// </summary>
        protected IFilter _exitingTransition;

        /// <summary>
        /// <see cref="IEntity">IEntity's</see> perminant <see cref="IFilter">IFilters</see>.
        /// </summary>
        protected IList<IFilter> _filters;

        /// <summary>
        /// <see cref="IEntity">IEntity's</see> unique identifier.
        /// </summary>
        protected string _id;

        /// <summary>
        /// Whether the <see cref="Entity"/> is being hovered by the cursor.
        /// </summary>
        protected bool _isHovered;

        /// <summary>
        /// <see cref="IEntity">IEntity's</see> layer depth for rendering.
        /// </summary>
        protected float _layerDepth;

        /// <summary>
        /// Anchor's relation to <see cref="IEntity">IEntity's</see> position.
        /// </summary>
        protected Origin _origin;

        /// <summary>
        /// <see cref="IEntity">IEntity's</see> current <see cref="TransitionState"/>.
        /// </summary>
        protected TransitionState _transitionState;
    }
}
