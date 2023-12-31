using UnityEngine;

namespace GameProject3.ScriptableObjects
{

    [CreateAssetMenu(fileName = "Attack Info", menuName = "Combat/Attack Information/Craete New", order = 51)]
    public class AttackSO : ScriptableObject
    {
        [SerializeField] float _floatValue = 1f;
        [SerializeField] int _damage = 10;
        [SerializeField] LayerMask _layerMask;
        [SerializeField] float _attackMaxDelay = 0.25f;
        [SerializeField] AnimatorOverrideController _animatorOverride;
        [SerializeField] AudioClip _audioClip;


        public float AttackMaxDelay => _attackMaxDelay;
        public float FloatValue => _floatValue;
        public int Damage => _damage;
        public LayerMask LayerMask => _layerMask;
        public AnimatorOverrideController AnimatorOverride => _animatorOverride;
        public AudioClip AudioClip => _audioClip;
    }

}
