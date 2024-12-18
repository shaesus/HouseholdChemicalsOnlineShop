import "./CartProductCard.css";

const CartProductCard = ({ product, onDeleteFromCart }) => {
    const { id, name, description, imagePath, price, stockQuantity } = product;

    const imageUrl = `/images${imagePath}`;

    const onDelete = async () => {
        await onDeleteFromCart(id);
    };

    return (
        <div className="cartproduct-card">
            <img src={imageUrl} alt={name} className="cartproduct-image" />
            <div className="cartproduct-details">
                <span className="cartproduct-name">{name}</span>
                <span className="cartproduct-price">{price} ₽</span>
                <button className="remove-button" onClick={onDelete}>
                    Удалить из корзины
                </button>
            </div>
        </div>
    );
}

export default CartProductCard;