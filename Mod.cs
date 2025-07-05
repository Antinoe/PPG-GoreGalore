using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Linq;
using TMPro;
using UnityEngine.UI;
namespace Mod
{
	public enum VoiceProfile
	{
		NoVoice,
		WheelchairGuy,
		SegwayGuy,
		IrresponsibleDad,
		IrresponsibleMom,
		MopedGuy,
		MopedGirl,
		LawnmowerGuy,
		PogoStickGuy,
		HelicopterGuy,
		Kid1,
		// 👧 Refer to the explanation at the HappyWheels_Kid2 Audio Clip.
		//Kid2,
		Elf,
		Santa
	}
	public class Mod : MonoBehaviour
	{
		public static AudioClip[] HappyWheels_BoneSnap = new AudioClip[4]{
			ModAPI.LoadSound("Assets/HappyWheels/Gore/BoneBreak1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Gore/BoneBreak2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Gore/BoneBreak3.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Gore/BoneBreak4.wav")
		};
		public static AudioClip[] HappyWheels_LimbSplit = new AudioClip[3]{
			ModAPI.LoadSound("Assets/HappyWheels/Gore/LimbRip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Gore/LimbRip3.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Gore/LimbRip4.wav")
		};
		public static AudioClip HappyWheels_HeadSplit;
		public static AudioClip HappyWheels_HeadSmash;
		public static AudioClip HappyWheels_ChestSplit;
		public static AudioClip HappyWheels_ChestSmash;
		public static AudioClip HappyWheels_PelvisSmash;
		public static void OnLoad()
		{
			HappyWheels_HeadSplit = ModAPI.LoadSound("Assets/HappyWheels/Gore/NeckBreak.wav");
			HappyWheels_HeadSmash = ModAPI.LoadSound("Assets/HappyWheels/Gore/HeadSmash.wav");
			HappyWheels_ChestSplit = ModAPI.LoadSound("Assets/HappyWheels/Gore/LimbRip1.wav");
			HappyWheels_ChestSmash = ModAPI.LoadSound("Assets/HappyWheels/Gore/ChestSmash.wav");
			HappyWheels_PelvisSmash = ModAPI.LoadSound("Assets/HappyWheels/Gore/PelvisSmash.wav");
		}
		public static AudioClip[] HappyWheels_WheelchairGuy = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char1Torso.wav")
		};
		public static AudioClip[] HappyWheels_SegwayGuy = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char2Torso.wav")
		};
		public static AudioClip[] HappyWheels_IrresponsibleDad = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char3Torso.wav")
		};
		public static AudioClip[] HappyWheels_IrresponsibleMom = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char4Torso.wav")
		};
		public static AudioClip[] HappyWheels_MopedGuy = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char8Torso.wav")
		};
		public static AudioClip[] HappyWheels_MopedGirl = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char9Torso.wav")
		};
		public static AudioClip[] HappyWheels_LawnmowerGuy = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char11Torso.wav")
		};
		public static AudioClip[] HappyWheels_PogoStickGuy = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Char12Torso.wav")
		};
		public static AudioClip[] HappyWheels_HelicopterGuy = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliElbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliElbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliFoot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliFoot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliHip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliHip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliKnee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliKnee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliPelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliShoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliShoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliSpikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/HeliTorso.wav")
		};
		public static AudioClip[] HappyWheels_Kid1 = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid1Torso.wav")
		};
		// 👧She has 9 files, not the usual 13. We need to work around this.
		/*
		public static AudioClip[] HappyWheels_Kid2 = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Kid2Torso.wav")
		};
		*/
		public static AudioClip[] HappyWheels_Elf = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Elbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Elbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Foot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Foot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Hip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Hip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Knee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Knee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Pelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Shoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Shoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Spikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/Elf1Torso.wav")
		};
		public static AudioClip[] HappyWheels_Santa = new AudioClip[13]{
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaElbow1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaElbow2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaFoot1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaFoot2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaHip1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaHip2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaKnee1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaKnee2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaPelvis.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaShoulder1.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaShoulder2.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaSpikes.wav"),
			ModAPI.LoadSound("Assets/HappyWheels/Voices/SantaTorso.wav")
		};
		public static void Main()
		{
			ModAPI.FindSpawnable("Human").Prefab.AddComponent<GoreGaloreBootstrapper>();
			ModAPI.OnItemSpawned += (sender, args) =>
			{
				var person = args.Instance.GetComponent<PersonBehaviour>();
				if (person == null) return;

				var brainLimb = person.Limbs.FirstOrDefault(l => l.HasBrain) ?? person.Limbs[0];

				// Ensure VoiceManager exists.
				var voice = brainLimb.GetComponent<VoiceManager>();
				if (voice == null) { voice = brainLimb.gameObject.AddComponent<VoiceManager>(); }
				var phys = brainLimb.PhysicalBehaviour;
				// 🪲🔨 I need to remove all of the buttons bellow and make a single Voice Menu to open.. I just don't know how yet.
				/*
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"CycleVoice",
					"VOICE: Cycle Voice",
					"VOICE: Cycle Voice",
					new UnityAction[] {
						() => {
							var enumValues = Enum.GetValues(typeof(VoiceProfile));
							int currentIndex = Array.IndexOf(enumValues, voice.voiceProfile);
							int nextIndex = (currentIndex + 1) % enumValues.Length;
							voice.voiceProfile = (VoiceProfile)enumValues.GetValue(nextIndex);
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				*/
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceNone",
					"VOICE: NONE",
					"VOICE: NONE",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.NoVoice; // 🔇 No voice assigned.
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceWheelchairGuy",
					"VOICE: Wheelchair Guy",
					"VOICE: Wheelchair Guy",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.WheelchairGuy;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceSegwayGuy",
					"VOICE: Segway Guy",
					"VOICE: Segway Guy",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.SegwayGuy;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceIrresponsibleDad",
					"VOICE: Irresponsible Dad",
					"VOICE: Irresponsible Dad",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.IrresponsibleDad;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceIrresponsibleMom",
					"VOICE: Irresponsible Mom",
					"VOICE: Irresponsible Mom",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.IrresponsibleMom;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceMopedGuy",
					"VOICE: Moped Guy",
					"VOICE: Moped Guy",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.MopedGuy;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceMopedGirl",
					"VOICE: Moped Girl",
					"VOICE: Moped Girl",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.MopedGirl;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceLawnmowerGuy",
					"VOICE: Lawnmower Guy",
					"VOICE: Lawnmower Guy",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.LawnmowerGuy;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoicePogoStickGuy",
					"VOICE: Pogo Stick Guy",
					"VOICE: Pogo Stick Guy",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.PogoStickGuy;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceHelicopterGuy",
					"VOICE: Helicopter Guy",
					"VOICE: Helicopter Guy",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.HelicopterGuy;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceKid1",
					"VOICE: Kid 1",
					"VOICE: Kid 1",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.Kid1;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceElf",
					"VOICE: Elf",
					"VOICE: Elf",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.Elf;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
				phys.ContextMenuOptions.Buttons.Add(new ContextMenuButton(
					"VoiceSanta",
					"VOICE: Santa",
					"VOICE: Santa",
					new UnityAction[] {
						() => {
							voice.voiceProfile = VoiceProfile.Santa;
							ModAPI.Notify($"New Voice: {voice.voiceProfile}");
							if (voice.person?.IsAlive() == true && !voice.source.isPlaying)
							{
								voice.PlayRandom(voice.VoiceClips);
							}
						}
					}
				));
			};
		}
	}
	public class GoreGaloreBootstrapper : MonoBehaviour
	{
		void Awake()
		{
			var person = GetComponent<PersonBehaviour>();
			var screamLimb = person.Limbs.FirstOrDefault(l => l.HasBrain) ?? person.Limbs[0];
			if (screamLimb.GetComponent<VoiceManager>() == null)
			{
				screamLimb.gameObject.AddComponent<VoiceManager>();
			}
			foreach (var l in person.Limbs)
			{
				if (l.gameObject.GetComponent<GoreManager>() == null)
				{
					l.gameObject.AddComponent<GoreManager>().limb = l;
				}
			}
		}
	}
	public class GoreManager : MonoBehaviour
	{
		public LimbBehaviour limb;
		public GoreAudioSource gore;
		public VoiceManager scream;
		// LimbBehaviour.Numbess > 0.5f = No Pain.
		void Awake()
		{
			if (limb == null) { limb = GetComponent<LimbBehaviour>(); }
			gore = gameObject.GetOrAddComponent<GoreAudioSource>();
			if (limb?.Person != null)
			{
				scream = limb.Person.Limbs.FirstOrDefault(l => l.HasBrain)?.GetComponent<VoiceManager>();
			}
		}
		void OnDisable()
		{
			Debug.Log($"Crushed '{limb?.name}'.");
			AudioSource.PlayClipAtPoint(Mod.HappyWheels_BoneSnap[UnityEngine.Random.Range(0, Mod.HappyWheels_BoneSnap.Length)], transform.position, 1f);
			if (limb.name.ToLower().Contains("head"))
			{
				AudioSource.PlayClipAtPoint(Mod.HappyWheels_HeadSmash, transform.position, 1f);
			}
			if (limb.name.ToLower().Contains("upperbody"))
			{
				AudioSource.PlayClipAtPoint(Mod.HappyWheels_ChestSmash, transform.position, 1f);
				scream?.Play(scream.VoiceClips[8]);
			}
			if (limb.name.ToLower().Contains("middlebody"))
			{
				AudioSource.PlayClipAtPoint(Mod.HappyWheels_PelvisSmash, transform.position, 1f);
				scream?.Play(scream.VoiceClips[8]);
			}
			if (limb.name.ToLower().Contains("lowerbody"))
			{
				AudioSource.PlayClipAtPoint(Mod.HappyWheels_PelvisSmash, transform.position, 1f);
				scream?.Play(scream.VoiceClips[8]);
			}
			VoiceGeneric();
		}

		public void Shot(Shot shot)
		{
			VoiceGeneric();
		}
		public void Stabbed(Stabbing stabbing)
		{
			VoiceGeneric();
		}
		public virtual void VoiceGeneric()
		{
			var isLimb = limb.name.ToLower().Contains("foot") || limb.name.ToLower().Contains("leg") || limb.name.ToLower().Contains("arm") || limb.name.ToLower().Contains("body") || limb.name.ToLower().Contains("head");
			if (isLimb)
			{
				if (scream != null && scream.VoiceClips != null && scream.VoiceClips.Length > 0)
				{
					var validIndexes = Enumerable.Range(0, scream.VoiceClips.Length)
						.Where(i => i != 8 && i != 12)
						.ToArray();
					if (validIndexes.Length > 0)
					{
						int idx = validIndexes[UnityEngine.Random.Range(0, validIndexes.Length)];
						scream.Play(scream.VoiceClips[idx]);
					}
				}
			}
		}
		// Taken from the Scream mod. Probably needs edited.
		private ContactPoint2D[] contactBuffer = new ContactPoint2D[8];
		public void OnCollisionEnter2D(Collision2D Col)
		{
			int contacts = Col.GetContacts(contactBuffer);
			float num = Utils.GetMinImpulse(contactBuffer, contacts);
			Vector2 point = contactBuffer[0].point;
			Vector2 normal = contactBuffer[0].normal;
			if (num >= 2.00f)
			{
				VoiceGeneric();
			}
		}
		public void OnJointBreak2D(Joint2D joint)
		{
			Debug.Log($"Joint broken! Limb: {limb.name}");
			if (joint == limb.Joint)
			{
				gore.PlayRandom(Mod.HappyWheels_BoneSnap);
				gore.PlayRandom(Mod.HappyWheels_LimbSplit);
				if (limb.name.ToLower().Contains("head"))
				{
					gore.Play(Mod.HappyWheels_HeadSplit);
				}
				if (limb.name.ToLower().Contains("upperbody"))
				{
					gore.Play(Mod.HappyWheels_ChestSplit);
					scream?.Play(scream.VoiceClips[12]);
				}
				if (limb.name.ToLower().Contains("middlebody"))
				{
					gore.Play(Mod.HappyWheels_ChestSplit);
					scream?.Play(scream.VoiceClips[12]);
				}
				if (limb.name.ToLower().Contains("lowerbody"))
				{
					gore.Play(Mod.HappyWheels_ChestSplit);
					scream?.Play(scream.VoiceClips[12]);
				}
				VoiceGeneric();
			}
		}
		// Taken from the Scream mod. Probably needs edited.
		public bool oldBoneBroken;
		public void Update()
		{
			if (limb.Person.PainLevel > 0.3f)
			{
				if (scream != null && scream.VoiceClips != null && scream.VoiceClips.Length > 12)
				{
					int idx = UnityEngine.Random.value < 0.5f ? 8 : 12;
					scream.Play(scream.VoiceClips[idx]);
				}
			}
			/*
			if (this.oldBoneBroken != limb.Broken && limb.Person.IsAlive())
			{
				oldBoneBroken = limb.Broken;
				if (limb.Broken == true)
				{
					VoiceGeneric();
				}
			}
			*/
		}
	}
	public class GoreAudioSource : MonoBehaviour
	{
		private AudioSource audio;
		void Awake()
		{
			audio = gameObject.AddComponent<AudioSource>();
			audio.spatialBlend = 1f;
			audio.volume = 10f;
			audio.minDistance = 2f;
			audio.maxDistance = 25f;
			audio.dopplerLevel = 0f;
			gameObject.AddComponent<AudioSourceTimeScaleBehaviour>(); // ⌛PPG sync.
			Global.main.AddAudioSource(audio); // 🌍Register globally.
		}
		public void Play(AudioClip clip)
		{
			if (clip == null)
			{
				Debug.Log("Attempted to play a null clip!");
				return;
			}
			audio.clip = clip;
			audio.Play();
		}
		public void PlayRandom(AudioClip[] clips)
		{
			if (clips == null)
			{
				Debug.Log("Attempted to play null clips!");
				return;
			}
			if (clips != null && clips.Length > 0) { Play(clips[UnityEngine.Random.Range(0, clips.Length)]); }
		}
	}
	public class VoiceManager : MonoBehaviour
	{
		public AudioSource source; // 🔊Audio source for screams.
		public PersonBehaviour person; // 👤Reference to the person this limb belongs to.
		public VoiceProfile voiceProfile; // 🎤Voice profile for the character.
		public bool voiceAssigned = false; // 🔖Flag to check if a voice is assigned. (Doesn't work with cloning yet...)
		public AudioClip[] VoiceClips
		{
			get
			{
				switch (voiceProfile)
				{
					case VoiceProfile.NoVoice:
						return null; // 🔇 No voice assigned.
					case VoiceProfile.WheelchairGuy:
						return Mod.HappyWheels_WheelchairGuy;
					case VoiceProfile.SegwayGuy:
						return Mod.HappyWheels_SegwayGuy;
					case VoiceProfile.IrresponsibleDad:
						return Mod.HappyWheels_IrresponsibleDad;
					case VoiceProfile.IrresponsibleMom:
						return Mod.HappyWheels_IrresponsibleMom;
					case VoiceProfile.MopedGuy:
						return Mod.HappyWheels_MopedGuy;
					case VoiceProfile.MopedGirl:
						return Mod.HappyWheels_MopedGirl;
					case VoiceProfile.LawnmowerGuy:
						return Mod.HappyWheels_LawnmowerGuy;
					case VoiceProfile.PogoStickGuy:
						return Mod.HappyWheels_PogoStickGuy;
					case VoiceProfile.HelicopterGuy:
						return Mod.HappyWheels_HelicopterGuy;
					case VoiceProfile.Kid1:
						return Mod.HappyWheels_Kid1;
					// 👧 Refer to the explanation at the HappyWheels_Kid2 Audio Clip.
					//case VoiceProfile.Kid2:
					//	return Mod.HappyWheels_Kid2;
					case VoiceProfile.Elf:
						return Mod.HappyWheels_Elf;
					case VoiceProfile.Santa:
						return Mod.HappyWheels_Santa;
					default:
						return Mod.HappyWheels_SegwayGuy;
				}
			}
		}
		void Awake()
		{
			source = gameObject.AddComponent<AudioSource>();
			source.spatialBlend = 1f;
			source.volume = 5f;
			source.minDistance = 3f;
			source.maxDistance = 30f;
			source.playOnAwake = false;
			source.dopplerLevel = 0f;
			gameObject.AddComponent<AudioSourceTimeScaleBehaviour>();
			Global.main.AddAudioSource(source);
			person = GetComponent<LimbBehaviour>()?.Person;
			if (!voiceAssigned)
			{
				voiceProfile = (VoiceProfile)UnityEngine.Random.Range(0, Enum.GetValues(typeof(VoiceProfile)).Length);
				voiceAssigned = true; // 🏷️Mark voice as assigned. (Doesn't work with copying/saving yet...)
			}
			//SpecialVoices();
			Debug.Log($"Assigned Voice: {voiceProfile}");
		}
		// 🪲🔨Doesn't work...
		/*
		public void SpecialVoices()
		{
			//Debug.Log("Attempting to assign custom voice..");
			if (person == null)
			{
				Debug.Log("PersonBehaviour is null, cannot assign special voice!");
				return;
			}
			string prefabName = person.gameObject.name;
			// 🏗️Defaults
			if (prefabName.ToLower().Contains("baby") || prefabName.ToLower().Contains("child") || prefabName.ToLower().Contains("toddler") || prefabName.ToLower().Contains("kid"))
			{
				voiceProfile = VoiceProfile.Kid1;
			}
			if (prefabName.ToLower().Contains("human"))
			{
				voiceProfile = VoiceProfile.MopedGuy;
			}
			if (prefabName.ToLower().Contains("santa"))
			{
				voiceProfile = VoiceProfile.Santa;
			}
			if (prefabName.ToLower().Contains("elf"))
			{
				voiceProfile = VoiceProfile.Elf;
			}
			// 🦸🏻Invincible
			if (prefabName.ToLower().Contains("bulletproof"))
			{
				voiceProfile = VoiceProfile.LawnmowerGuy;
			}
			if (prefabName.ToLower().Contains("conquest"))
			{
				voiceProfile = VoiceProfile.Santa;
			}
			if (prefabName.ToLower().Contains("omni"))
			{
				voiceProfile = VoiceProfile.IrresponsibleDad;
			}
			if (prefabName.ToLower().Contains("invincible"))
			{
				voiceProfile = VoiceProfile.PogoStickGuy;
			}
			if (prefabName.ToLower().Contains("homelander"))
			{
				voiceProfile = VoiceProfile.MopedGuy;
			}
		}
		*/
		void Update()
		{
			if (person != null && !person.IsAlive() && source.isPlaying)
			{
				source.Stop(); // 🔇 Stop scream if person is dead.
			}
		}
		public void Play(AudioClip clip)
		{
			if (voiceProfile == null)
			{
				return;
			}
			if (clip == null)
			{
				Debug.Log("Attempted to play a null clip!");
				return;
			}
			// 🔊Check if the person is alive and the source is not already playing.
			if (person?.IsAlive() == true && !source.isPlaying)
			{
				//source.Stop(); // 🔇 Stop any currently playing clip.
				source.clip = clip;
				source.Play();
			}
		}
		public void PlayRandom(AudioClip[] clips)
		{
			if (voiceProfile == null)
			{
				return;
			}
			if (clips == null)
			{
				Debug.Log("Attempted to play null clips!");
				return;
			}
			if (clips?.Length > 0 && person?.IsAlive() == true && !source.isPlaying)
			{
				source.clip = clips[UnityEngine.Random.Range(0, clips.Length)];
				source.Play();
			}
		}
	}
}