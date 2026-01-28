using UnityEngine;

public class RagdollToggle : MonoBehaviour
{
    public Animator animator;

    [Header("Main Rigidbody (root/body)")]
    public Rigidbody mainRigidbody; // <- this becomes kinematic during ragdoll
    public Collider mainCollider;   // optional (capsule, etc.)

    [Header("Ragdoll Parts")]
    public Rigidbody[] ragdollBodies;
    public Collider[] ragdollColliders;

    bool isRagdolled;

    void Awake()
    {
         if (!mainRigidbody) 
            mainRigidbody = GetComponent<Rigidbody>();
        if (!mainCollider) 
            mainCollider = GetComponent<Collider>();
        if (!animator) animator = GetComponentInChildren<Animator>();

        if (ragdollBodies == null || ragdollBodies.Length == 0)
            ragdollBodies = GetComponentsInChildren<Rigidbody>(true);

        if (ragdollColliders == null || ragdollColliders.Length == 0)
            ragdollColliders = GetComponentsInChildren<Collider>(true);
    }

    void Start()
    {
        SetRagdoll(false);
    }
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("RagdollTrigger"))
        {
            //SetRagdoll(true);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) SetRagdoll(true);
        if (Input.GetKeyDown(KeyCode.T)) SetRagdoll(false);
    }

    public void SetRagdoll(bool enable)
    {
        isRagdolled = enable;

        // Animator off when ragdoll is active
        if (animator) animator.enabled = !enable;

        // MAIN BODY becomes kinematic when ragdoll is active
        if (mainRigidbody)
        {
            mainRigidbody.isKinematic = enable;
            mainRigidbody.detectCollisions = !enable;
        }
        // Option A: keep capsule ON so the root can't fall through the world
        if (mainCollider) mainCollider.enabled = true;

        // Enable physics on ragdoll bodies
        foreach (var rb in ragdollBodies)
        {
            if (!rb || rb == mainRigidbody) continue;

            rb.isKinematic = !enable;
            rb.detectCollisions = enable;
        }

        foreach (var col in ragdollColliders)
        {
            if (!col || col == mainCollider) continue;
            col.enabled = enable;
        }
    }
}
