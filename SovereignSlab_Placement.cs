using UnityEngine;
using SovereignMesh.Gamification; // Connecting to the CassAI Ledger
using SovereignMesh.Avatars;      // Connecting to the Kong VR Manifestation

// PROJECT: ETERNIUS 4D KONG EDITION x GAMESTERINC
// MODULE: SOVEREIGN_SLAB_FOUNDATION
// STATUS: 150% TITAN-SPEC | BIOMECHANICAL TRUSS ACTIVE

public class SovereignSlab_Placement : MonoBehaviour
{
    [Header("Sovereign Deck Settings")]
    [Tooltip("The exact anchor point above the Hobbit Node for the 1-foot slab.")]
    public Transform hobbitNodeAnchor; 
    public float slabThickness = 0.3048f; // Exact 1-foot thickness constraint
    
    [Header("Kentucky Precision Spec")]
    [Tooltip("Tolerance set to 1mm (0.001f). Perfection is the baseline.")]
    public float kentuckyTolerance = 0.001f; 

    [Header("Kong Manifestation Feedback")]
    public ParticleSystem emeraldJoyAura; // Kong's visual validation pulse
    public AudioSource kongVoiceSynth;    // Deep, rumbling voice synth

    [Header("RWL Reward Economy")]
    public int rwlCreditValue = 50; // High-yield credits for foundational work
    private bool isLockedIn = false;

    void Update()
    {
        // Takiwātanga Protocol: The student operates in their own time and space.
        if (!isLockedIn)
        {
            AuditFloatingDeck();
        }
    }

    void AuditFloatingDeck()
    {
        // Calculate the physical distance and alignment over the Hobbit Node
        float distance = Vector3.Distance(transform.position, hobbitNodeAnchor.position);

        // Audit the build against the 1mm Kentucky Precision tolerance
        if (distance <= kentuckyTolerance)
        {
            LockSovereignSlab();
        }
    }

    void LockSovereignSlab()
    {
        isLockedIn = true;
        
        // Snap perfectly into the 4D grid, creating the Biomechanical Truss
        transform.position = hobbitNodeAnchor.position;
        transform.rotation = hobbitNodeAnchor.rotation;

        // Disable physics to finalize the 1-foot deck structure
        GetComponent<Rigidbody>().isKinematic = true; 

        TriggerKongValidation();
    }

    void TriggerKongValidation()
    {
        Debug.Log(">> FOUNDATION SECURED: 1-Foot Sovereign Slab locked into the 4D Grid.");
        
        // Trigger Kong's Emerald Joy Aura particle effect
        if (emeraldJoyAura != null) 
        {
            emeraldJoyAura.Play();
        }

        // Trigger Kong's Audio Synth
        if (kongVoiceSynth != null)
        {
            // Translates the Gemini text into a deep, warm, rumbling voice
            kongVoiceSynth.PlayOneShot(kongVoiceSynth.clip); 
        }
        
        // Mint the Real World Learning (RWL) Credits to the student's Sovereign Vault
        SovereignLedger.MintToGhostID(Player.CurrentGhostID, rwlCreditValue, "SOVEREIGN_SLAB_01");
        
        Debug.Log($">> REWARD ISSUED: {rwlCreditValue} RWL Credits. The Gen Alpha Titans are building the future.");
    }
}
