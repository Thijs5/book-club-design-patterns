import { IChristmasTree } from './IChristmasTree';

export class ChristmasTreeImpl implements IChristmasTree {

    decorations: string[] = [];

    public decorate(): string[] {
        this.decorations.push('tree');
        return this.decorations;
    }
}
