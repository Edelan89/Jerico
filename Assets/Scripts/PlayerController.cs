using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] protected Transform movePoint;
    [SerializeField] protected float moveSpeed = 5f;

    public Grid grid;

    public LayerMask whatStopsMovement;
    private Vector3Int _targetCell;

    public bool IsMoving => transform.position != movePoint.position;

    void Start()
    {
        movePoint.parent = null;

        _targetCell = grid.WorldToCell(transform.position);
        transform.position = grid.CellToWorld(_targetCell);
        movePoint.position = grid.CellToWorld(_targetCell);
    }
    void Update()
    {
        MoveObject();
    }
    protected void MoveObject()
    {
        var xInput = Input.GetAxisRaw("Horizontal");
        var yInput = Input.GetAxisRaw("Vertical");

        if (transform.position != movePoint.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, movePoint.position) > .05f) return;

        //Vector3Int gridMovement = new Vector3Int();

        if (Mathf.Abs(xInput) == 1f)
        {
            // _targetCell +=  new Vector3Int((int)xInput, 0, 0);
            Vector3Int gridMovement = new Vector3Int((int)xInput, 0, 0);
            var nextPos = grid.CellToWorld(_targetCell + gridMovement);

            if (Physics2D.OverlapCircle(nextPos, .1f, whatStopsMovement)) return;

            movePoint.position = nextPos;
            _targetCell += gridMovement;
        }
        else if (Mathf.Abs(yInput) == 1f)
        {
            Vector3Int gridMovement = new Vector3Int(0, (int)yInput, 0);
            var nextPos = grid.CellToWorld(_targetCell + gridMovement);

            if (Physics2D.OverlapCircle(nextPos, .1f, whatStopsMovement)) return;

            movePoint.position = nextPos;
            _targetCell += gridMovement;
        }

        //Vector3Int cell = grid.WorldToCell(movePoint.position);
        //movePoint.position = grid.GetCellCenterWorld(cell);

    }

    /*
        public Grid grid;
        public float moveSpeed = 5f;

        private Vector3Int _targetCell;
        private Vector2 _targetPosition;

        private void Start()
        {
            // get initial grid location
            _targetCell = grid.WorldToCell(transform.position);

            // snap to the current cell
            transform.position = grid.CellToWorld(_targetCell);
        }

        private void Update()
        {
            Vector3Int gridMovement = new Vector3Int();

            if (Input.GetKeyDown(KeyCode.W))
            {
                gridMovement.y += 1;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                gridMovement.y -= 1;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                gridMovement.x -= 1;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                gridMovement.x += 1;
            }

            if (gridMovement != Vector3Int.zero)
            {
                _targetCell += gridMovement;
                _targetPosition = grid.CellToWorld(_targetCell);

            }
            else
            {
                if (Physics2D.OverlapCircle(movePoint.position + new Vector3(xInput, 0f, 0f), .1f, whatStopsMovement)) return;
                _targetPosition = 
            }

            MoveToward(_targetPosition);
        }

        private void MoveToward(Vector2 target)
        {
            if(_targetCell == grid.)

            transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
        }
        */
}


