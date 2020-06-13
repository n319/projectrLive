import { ModelData } from './data.model';
import { Project } from './project.model';
import { ViewTypeAttribute, IViewTypeAttribute } from './view-type-attribute.model';
import { Piece } from './piece.model';
import { ViewType } from './view-type.model';

export interface IBoardComponentData {
    viewType: ViewType;
    viewTypeAttributes: ViewTypeAttribute[];
    project: Project;
    projectPieces: Piece[]; 
}

export class BoardComponentData implements IBoardComponentData {
    static tableName = 'Board';
    viewType: ViewType;
    viewTypeAttributes: ViewTypeAttribute[];
    project: Project;
    projectPieces: Piece[];

    constructor(props: BoardComponentData) {
        Object.keys(props).forEach(prop => {
            const value = props[prop];
            this[prop] = value;
        });
    }
}