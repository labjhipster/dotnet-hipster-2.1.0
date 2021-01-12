import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { HumanResourcesSharedModule } from 'app/shared/shared.module';
import { PieceOfWorkComponent } from './piece-of-work.component';
import { PieceOfWorkDetailComponent } from './piece-of-work-detail.component';
import { PieceOfWorkUpdateComponent } from './piece-of-work-update.component';
import { PieceOfWorkDeleteDialogComponent } from './piece-of-work-delete-dialog.component';
import { pieceOfWorkRoute } from './piece-of-work.route';

@NgModule({
  imports: [HumanResourcesSharedModule, RouterModule.forChild(pieceOfWorkRoute)],
  declarations: [PieceOfWorkComponent, PieceOfWorkDetailComponent, PieceOfWorkUpdateComponent, PieceOfWorkDeleteDialogComponent],
  entryComponents: [PieceOfWorkDeleteDialogComponent],
})
export class HumanResourcesPieceOfWorkModule {}
