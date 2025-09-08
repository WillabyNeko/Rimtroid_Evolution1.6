using RimWorld;
using Verse;
using Verse.Sound;
using UnityEngine;
/*
namespace RT_Rimtroid
{
    public class PawnFlyer_LungeAndLatch : PawnFlyer
    {
        private Vector3 startVec;
        private Vector3 endVec;
        private int startingTicks;

        public override void Launch(Pawn pawn, IntVec3 destCell, LocalTargetInfo target, PawnsArrivalModeDef arrivalMode, bool drafted = false)
        {
            // Store positions for lerp
            startVec = pawn.DrawPos;
            endVec = destCell.ToVector3Shifted();
            startingTicks = TicksLeft;
            base.Launch(pawn, destCell, target, arrivalMode, drafted);
        }

        public override void DrawAt(Vector3 drawLoc, bool flip = false)
        {
            // Progress from 0 -> 1
            float progress = 1f - ((float)TicksLeft / (float)startingTicks);

            // Smooth interpolation between start and end
            Vector3 flatPos = Vector3.Lerp(startVec, endVec, progress);

            // Keep pawn at normal altitude (no leap arc)
            flatPos.y = Altitudes.AltitudeFor(AltitudeLayer.Pawn);

            // Assign for rendering
            DrawPos = flatPos;

            // Draw the actual pawn
            if (innerPawn != null)
            {
                innerPawn.Drawer.DrawAt(flatPos);
            }
        }

        public override void Tick()
        {
            base.Tick();

            // Optional: spawn a faint trail behind the lunge
            if (Find.TickManager.TicksGame % 2 == 0)
            {
                MoteMaker.ThrowDustPuff(DrawPos, Map, 0.5f);
            }
        }

        protected override void Impact()
        {
            base.Impact();

            // Play an impact sound
            SoundDefOf.Pawn_Melee_Punch_HitPawn.PlayOneShot(new TargetInfo(DestinationCell, Map));

            // Example: latch onto target if it’s a pawn
            if (destinationCell.IsValid)
            {
                Pawn victim = destinationCell.GetFirstPawn(Map);
                if (victim != null && innerPawn != null)
                {
                    // Start your "feeding latch job" here
                    Job latchJob = JobMaker.MakeJob(DefDatabase<JobDef>.GetNamed("RT_AbsorbingEnergy"), victim);
                    innerPawn.jobs.StartJob(latchJob, JobCondition.InterruptForced);
                }
            }
        }
    }
}*/
